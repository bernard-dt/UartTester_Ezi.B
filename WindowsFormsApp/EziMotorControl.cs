using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace EziMotorApps
{
    public class EziMotorControl
    {
        private readonly SynchronizationContext _syncContext;
        private EziMotorService _ezisvc;        
        private SerialPort _port;
        public EziMotorControl(EziMotorService ezisvc, SerialPort port)
        {
            _syncContext = SynchronizationContext.Current;
            _ezisvc = ezisvc;            
            _port = port;
        }

        public void EziAutoMeasure_Start()
        {
            Thread thread1 = new Thread(EziAutoMeasure_Thread);
            thread1.IsBackground = true;
            thread1.Start();
        }
        public void EziAutoMeasure_Thread()
        {
            // cre control
            byte[] arrCaa = { 0xa4, 0xb4, 0x03, 0xF0, 0x13, 0x3 };


            // motor control 
            int[] arrEzi = { -28, -28, -27, -28, -28, -28, -27, -28, -28 };
            int s32Pos = 0;
            bool bTimeout = false, bDisconnected = false;

            _ezisvc.ClearPosition();
            WaitForMotionComplete(timeoutMs: 5000);

            _port.Write(arrCaa, 0, arrCaa.Length);
            Thread.Sleep(1000);

            for (int i = 0; i < 41; i++)  // +1
            {
                for (int j = 0; j < 9; j++)
                {
                    s32Pos += arrEzi[j];

                    _ezisvc.MoveAbsolute(s32Pos, 500);
                    if (!WaitForMotionComplete(timeoutMs: 5000))
                    {
                        bTimeout = true;
                        break;
                    }
                    if (!_ezisvc.IsConnected)
                    {
                        bDisconnected = true;
                        break;
                    }

                    _port.Write(arrCaa, 0, arrCaa.Length);
                    Thread.Sleep(1000);
                }
                if (bTimeout)
                {
                    _syncContext.Post(_ =>
                        MessageBox.Show($"Timeout! Position = {s32Pos}"), null);
                    break;
                }
                else if(bDisconnected)
                {
                    _syncContext.Post(_ =>
                        MessageBox.Show($"Disconnected !"), null);
                    break;
                }                    
            }
            if (!bTimeout && !bDisconnected)
            {
                _syncContext.Post(_ =>
                    MessageBox.Show($"Measuring Finished "), null);
            }

        }

        private bool WaitForMotionComplete(int timeoutMs = 5000)
        {
            int elapsed = 0;
            bool bRet = false;
            while (elapsed < timeoutMs)
            {
                uint status = 0;
                _ezisvc.GetAxisStatus(ref status);

                bool isMoving = (status & 0x08000000) != 0;
                if (!isMoving)
                {
                    bRet = true;
                    break;
                }
                else
                {
                    Thread.Sleep(10);
                    elapsed += 10;
                }
            }
            return bRet;
        }

        public void EziAutoVerify_Start()
        {
            Thread thread2 = new Thread(EziAutoVerify_Thread);
            thread2.IsBackground = true;
            thread2.Start();
        }
        public void EziAutoVerify_Thread()
        {
            // cre control            
            byte[] arrReboot = { 0xa4, 0xb4, 0x03, 0x0C, 0x20, 0x2C };                               // DBG_PRINT Dis
            


            // motor control 
            int[] arrEzi = { -28, -28, -27, -28, -28, -28, -27, -28, -28 };
            int s32Pos = 0;
            bool bTimeout = false, bDisconnected = false;

            _ezisvc.ClearPosition();
            WaitForMotionComplete(timeoutMs: 5000);

            _port.Write(arrReboot, 0, arrReboot.Length);
            Thread.Sleep(3000);

            for (int i = 0; i < 41; i++)  //+1
            {
                for (int j = 0; j < 9; j++)
                {
                    s32Pos += arrEzi[j];

                    _ezisvc.MoveAbsolute(s32Pos, 500);
                    if (!WaitForMotionComplete(timeoutMs: 5000))
                    {
                        bTimeout = true;
                        break;
                    }
                    if (!_ezisvc.IsConnected)
                    {
                        bDisconnected = true;
                        break;
                    }

                    _port.Write(arrReboot, 0, arrReboot.Length);
                    Thread.Sleep(3000);
                }
                if (bTimeout)
                {
                    _syncContext.Post(_ =>
                        MessageBox.Show($"Timeout! Position = {s32Pos}"), null);
                    break;
                }
                else if (bDisconnected)
                {
                    _syncContext.Post(_ =>
                        MessageBox.Show($"Disconnected !"), null);
                    break;
                }
            }
            if (!bTimeout && !bDisconnected)
            {
                _syncContext.Post(_ =>
                    MessageBox.Show($"Verify finishied "), null);
            }

        }


        public void EziMoveIncrease(int pulse )
        {
            _ezisvc.MoveRelative(-pulse, 1000);

            if (!WaitForMotionComplete(timeoutMs: 10000))
            {
                _syncContext.Post(_ =>
                    MessageBox.Show($"Timeout !"), null);
            }
        }
        public void EziMoveDecrease(int pulse)
        {
            _ezisvc.MoveRelative(pulse, 1000);

            if (!WaitForMotionComplete(timeoutMs: 10000))
            {
                _syncContext.Post(_ =>
                    MessageBox.Show($"Timeout !"), null);
            }
        }

    }
}

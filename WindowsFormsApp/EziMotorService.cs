using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UartTester;

namespace EziMotorApps
{
    // EziMOTIONPlusR.dll P/Invoke rapper
    // RS-485 Comm. V6

    public class EziMotorService
    {
        // ─────────────────────────────────────────────
        // DLL 이름 상수
        // ─────────────────────────────────────────────
        private const string DLL_NAME = "Libs\\EziMOTIONPlusR";

        // ─────────────────────────────────────────────
        // 반환 코드 상수
        // ─────────────────────────────────────────────

        public const int FMM_OK = 0;   // 성공
        public const int FMM_NOT_OPEN = 1;   // 포트가 연결되지 않음
        public const int FMM_INVALID_PORT_NUM = 2;   // 잘못된 포트 번호
        public const int FMM_INVALID_SLAVE_NUM = 3;   // 잘못된 슬레이브 번호

        // ─────────────────────────────────────────────
        // Axis 상태 비트 상수
        // ─────────────────────────────────────────────
        public const uint AXISSTATUS_INPOSITION = 0x0001;
        public const uint AXISSTATUS_ALARM = 0x0008;
        public const uint AXISSTATUS_STOP = 0x0400;


        /// <param name="portNum">COM 포트 번호 (예: COM3 → 3)</param>
        /// <param name="baudRate">통신 속도 (115200 권장)</param>

        // ─────────────────────────────────────────────
        // P/Invoke - 연결 / 해제
        // ─────────────────────────────────────────────

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern bool FAS_OpenPort(byte portNum, uint baudRate);

        /// <summary>포트 해제</summary>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern void FAS_Close(byte portNum);

        /// <summary>연결된 슬레이브(축) 수 확인</summary>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int FAS_GetSlaveInfo(byte portNum, ref byte slaveCount);

        // ─────────────────────────────────────────────
        // P/Invoke - 서보 Enable / Disable
        // ─────────────────────────────────────────────

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int FAS_ServoEnable(byte portNum, byte slaveNum, bool enable);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern bool FAS_IsSlaveExist(byte portNum, byte slaveNum);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern bool FAS_AttachSlave(byte portNum, byte slaveNum);

        // ─────────────────────────────────────────────
        // P/Invoke - Position 기준 설정
        // ─────────────────────────────────────────────
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int FAS_ClearPosition(byte portNum, byte slaveNum);

        // ─────────────────────────────────────────────
        // P/Invoke - 이동 명령
        // ─────────────────────────────────────────────
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int FAS_MoveSingleAxisAbsPos(byte nPortNo, byte iSlaveNo, int lAbsPos, uint lVelocity);

        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int FAS_MoveSingleAxisIncPos(byte nPortNo, byte iSlaveNo, int lIncPos, uint lVelocity);


        /// <summary>절대 위치 이동</summary>
        /// <param name="absPos">목표 절대 위치 (pulse)</param>
        /// <param name="velocity">속도 (pulse/sec)</param>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int FAS_MoveToAbsPos(byte portNum, byte slaveNum,
                                                   int absPos, uint velocity);

        /// <summary>상대 위치 이동</summary>
        /// <param name="relPos">상대 이동량 (pulse, 음수 가능)</param>
        /// <param name="velocity">속도 (pulse/sec)</param>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int FAS_MoveToRelPos(byte portNum, byte slaveNum,
                                                   int relPos, uint velocity);

        /// <summary>원점 복귀</summary>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int FAS_MoveOrigin(byte portNum, byte slaveNum);

        // ─────────────────────────────────────────────
        // P/Invoke - 정지 명령
        // ─────────────────────────────────────────────

        /// <summary>감속 정지</summary>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int FAS_MoveStop(byte portNum, byte slaveNum);

        /// <summary>즉시 정지 (Emergency Stop)</summary>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int FAS_EmergencyStop(byte portNum, byte slaveNum);

        // ─────────────────────────────────────────────
        // P/Invoke - 상태 읽기
        // ─────────────────────────────────────────────

        /// <summary>현재 위치 읽기</summary>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int FAS_GetActualPos(byte portNum, byte slaveNum,
                                                   ref int actPos);

        /// <summary>축 상태 읽기</summary>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int FAS_GetAxisStatus(byte portNum, byte slaveNum,
                                                    ref uint axisStatus);

        /// <summary>알람 코드 읽기</summary>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int FAS_GetAlarmType(byte portNum, byte slaveNum,
                                                   ref uint alarmType);

        /// <summary>알람 클리어</summary>
        [DllImport(DLL_NAME, CallingConvention = CallingConvention.StdCall)]
        public static extern int FAS_ServoAlarmReset(byte portNum, byte slaveNum);

                                

        // ─────────────────────────────────────────────
        // 래퍼 - 편의 메서드
        // ─────────────────────────────────────────────

        private byte _portNum;
        private readonly byte _slaveNum;
        private bool _isConnected = false;

        public bool IsConnected => _isConnected;

        public EziMotorService(byte slaveNum)
        {
            _slaveNum = slaveNum;
        }

        /// <summary>연결</summary>
        public bool Connect(byte port, uint baudRate = 115200)
        {
            int u32Ret;
            bool bRet = false, bRet1, bRet2;


            _portNum = port;

            try
            {
                bRet1 = FAS_OpenPort(_portNum, baudRate);

                if (bRet1)
                {
                    bRet1 = FAS_AttachSlave(_portNum, _slaveNum);
                    bRet2 = FAS_IsSlaveExist(_portNum, _slaveNum);
                    if (bRet1 && bRet2)
                    {
                        u32Ret = FAS_ServoAlarmReset(_portNum, _slaveNum);
                        if (u32Ret == FMM_OK)
                        {
                            FAS_ServoEnable(_portNum, _slaveNum, true);                            
                            bRet = true;
                            MessageBox.Show("Connected ");
                        }
                        else
                        {
                            FAS_ServoEnable(_portNum, _slaveNum, false);
                            FAS_Close(_portNum);
                            bRet = false;
                            MessageBox.Show("Fail to Servo-On & Disconnected ");
                        }
                    }
                }
                else
                {
                    bRet = false;
                    MessageBox.Show("Fail to connect");                    
                }
            }
            catch (Exception ex)
            {
                bRet = false;
                throw new Exception($"Connect 실패: {ex.Message}");                
            }
            _isConnected = bRet;
            return bRet;
        }

        /// <summary>연결 해제</summary>
        public void Disconnect()
        {

            if (_isConnected)
            {
                FAS_ServoEnable(_portNum, _slaveNum, false);
                FAS_Close(_portNum);
                _isConnected = false;
            }
        }

        public void ClearPosition()
        {
            FAS_ClearPosition(_portNum, _slaveNum);
        }

        /// <summary>절대 위치 이동</summary>
        public int MoveAbsolute(int position, uint velocity = 10000)
        {
            int s32Ret;

            s32Ret = FAS_MoveSingleAxisAbsPos(_portNum, _slaveNum, position, velocity);
            return s32Ret;
        }

        /// <summary>상대 위치 이동</summary>
        public int MoveRelative(int distance, uint velocity = 10000)
        {
            int s32Ret;

            s32Ret =  FAS_MoveSingleAxisIncPos(_portNum, _slaveNum, distance, velocity);
            
            return s32Ret; 
        }

        public int GetAxisStatus(ref uint u32Status)
        {
            int u32Ret;
            u32Ret = FAS_GetAxisStatus(_portNum, _slaveNum, ref u32Status);
            return u32Ret;
        }


        /// <summary>감속 정지</summary>
        public bool Stop()
        {
            return FAS_MoveStop(_portNum, _slaveNum) == FMM_OK;
        }

        /// <summary>비상 정지</summary>
        public bool EmergencyStop()
        {
            return FAS_EmergencyStop(_portNum, _slaveNum) == FMM_OK;
        }

        /// <summary>현재 위치 반환</summary>
        public int GetCurrentPosition()
        {
            int pos = 0;
            FAS_GetActualPos(_portNum, _slaveNum, ref pos);
            return pos;
        }

        /// <summary>알람 여부 확인</summary>
        public bool HasAlarm()
        {
            uint status = 0;
            FAS_GetAxisStatus(_portNum, _slaveNum, ref status);
            return (status & AXISSTATUS_ALARM) != 0;
        }

        /// <summary>이동 완료 여부 확인</summary>
        public bool IsInPosition()
        {
            uint status = 0;
            FAS_GetAxisStatus(_portNum, _slaveNum, ref status);
            return (status & AXISSTATUS_INPOSITION) != 0;
        }

        /// <summary>알람 클리어</summary>
        public bool ClearAlarm()
        {
            return FAS_ServoAlarmReset(_portNum, _slaveNum) == FMM_OK;
        }
    }
}

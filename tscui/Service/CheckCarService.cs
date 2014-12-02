using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tscui.Models;

namespace tscui.Service
{
    class CheckCarService
    {
        public CheckCarService(byte[] ba, int len)
        {
           CheckCar(ba);
        }

        private void CheckCar(byte[] data)
        {
           DetectorStates.listDetectorState = new List<DetectorState>();
           DetectorStateObjects.listDetectorStateObject = new List<DetectorStateObject>();
            byte[] countDownArray = new byte[Define.DETECTOR_STATE_BYTE_LEN * Define.DETECTOR_STATE_BYTE_SIZE];
            Array.Copy(data, 4, countDownArray, 0, Define.DETECTOR_STATE_BYTE_LEN * Define.DETECTOR_STATE_BYTE_SIZE);
            byte[,] twoArray = ByteUtils.oneArray2TwoArray(countDownArray, Define.DETECTOR_STATE_BYTE_LEN, Define.DETECTOR_STATE_BYTE_SIZE);
            DetectorState ds;
            DetectorStateObject dso;
            for (int i = 0; i < Define.DETECTOR_STATE_BYTE_LEN; i++)
            {
                ds = new DetectorState();
                dso = new DetectorStateObject();

                dso.UcDetectorStateId = twoArray[i, 0];
                byte state = twoArray[i, 1];
                if (0x01 == (byte)(state & 0x01))
                {
                    dso.UcDetectorState1 = 0x01;
                }
                if (0x02 == (byte)(state & 0x02))
                {
                    dso.UcDetectorState2 = 0x01;
                }
                if (0x04 == (byte)(state & 0x04))
                {
                    dso.UcDetectorState3 = 0x01;
                }
                if (0x08 == (byte)(state & 0x08))
                {
                    dso.UcDetectorState4 = 0x01;
                }
                if (0x10 == (byte)(state & 0x10))
                {
                    dso.UcDetectorState5 = 0x01;
                }
                if (0x20 == (byte)(state & 0x20))
                {
                    dso.UcDetectorState6 = 0x01;
                }
                if (0x40 == (byte)(state & 0x40))
                {
                    dso.UcDetectorState7 = 0x01;
                }
                if (0x80 == (byte)(state & 0x80))
                {
                    dso.UcDetectorState8 = 0x01;
                }
                byte alert = twoArray[i, 2];
                if (0x01 == (byte)(alert & 0x01))
                {
                    dso.UcDetectorStateAlert1 = 0x01;
                }
                if (0x02 == (byte)(alert & 0x02))
                {
                    dso.UcDetectorStateAlert2 = 0x01;
                }
                if (0x04 == (byte)(alert & 0x04))
                {
                    dso.UcDetectorStateAlert3 = 0x01;
                }
                if (0x08 == (byte)(alert & 0x08))
                {
                    dso.UcDetectorStateAlert4 = 0x01;
                }
                if (0x10 == (byte)(alert & 0x10))
                {
                    dso.UcDetectorStateAlert5 = 0x01;
                }
                if (0x20 == (byte)(alert & 0x20))
                {
                    dso.UcDetectorStateAlert6 = 0x01;
                }
                if (0x40 == (byte)(alert & 0x40))
                {
                    dso.UcDetectorStateAlert7 = 0x01;
                }
                if (0x80 == (byte)(alert & 0x80))
                {
                    dso.UcDetectorStateAlert8 = 0x01;
                }

                ds.UcDetectorStateId = twoArray[i, 0];
                ds.UcDetectorState = twoArray[i, 1];
                ds.UcDetectorStateAlert = twoArray[i, 2];
                DetectorStates.listDetectorState.Add(ds);
                DetectorStateObjects.listDetectorStateObject.Add(dso);
            }
           
        }
       
     
    }
}

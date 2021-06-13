import pylogix
import UnityEngine as u

comm = pylogix.PLC("192.168.1.10")
comm.Write("DL14.output", False)

u.Debug.Log("Hi from python!")

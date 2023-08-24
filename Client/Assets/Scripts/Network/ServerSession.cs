using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using ServerCore;

namespace DummyClient
{
	public class ServerSession : PacketSession
    {
        public override void OnConnected(EndPoint endPoint)
        {
            Console.WriteLine($"OnConnected : {endPoint}");

   //         C_PlayerInfoReq packet = new C_PlayerInfoReq() { playerId = 1001, name ="ABCD" };

			//var skill = new C_PlayerInfoReq.Skill() { id = 101, duration = 1.0f, level = 1 };
			//skill.attributes.Add(new C_PlayerInfoReq.Skill.Attribute() { att = 77 });
			//packet.skills.Add(skill);

   //         packet.skills.Add(new C_PlayerInfoReq.Skill() { id = 102, duration = 2.0f, level = 2 });
   //         packet.skills.Add(new C_PlayerInfoReq.Skill() { id = 103, duration = 3.0f, level = 3 });
   //         packet.skills.Add(new C_PlayerInfoReq.Skill() { id = 104, duration = 4.0f, level = 4 });

   //         // 보낸다
   //         //for (int i = 0; i < 5; ++i)
   //         {
   //             ArraySegment<byte> s = packet.Write();
   //             if(s != null)
   //                 Send(s);
   //         }
        }

        public override void OnDisconnected(EndPoint endPoint)
        {
            Console.WriteLine($"OnDisconnted : {endPoint}");
        }

        public override void OnRecvPacket(ArraySegment<byte> buffer)
        {
            PacketManager.Instance.OnRecvPacket(this, buffer, (s, p) => { PacketQueue.Instance.Push(p); });
        }

        public override void Onsend(int numOfBytes)
        {
           // Console.WriteLine($"Transferred bytes : {numOfBytes}");
        }
    }
}

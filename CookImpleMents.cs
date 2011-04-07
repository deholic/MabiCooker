using System;
using System.Collections.Generic;
using System.Text;

namespace MabiCooker2
{
    public class Cook
    {
        private int cNumber;
        private String cName;
        private String cRank;
        private int[][] cEffect;
        private String[] effects;      // 구 버전 사용
        private String cSpecialEffect;
        private String[] cStuff;
        private int[] cStuffRatio;
        public Cook(string data)
        {   // v1 버전 알고리즘 그대로 사용. 뭐 괜찮잖아? ㅎㅎ
            // 근데 조금 수정할 필요는 있음. 효과 부분.
            short foodindex = 0, i = 0, j = 0;
            string[] datas = data.Split(';');
            string[] buffer;
            int[] intbuffer = new int[3];
            while (i < 5)
            {
                switch (i)
                {
                    case 0:
                        cNumber = foodindex;
                        cName = datas[i];
                        break;
                    case 1:
                        cRank = datas[i];
                        break;
                    case 2:
                        cStuff = datas[i].Split(',');
                        break;
                    case 3:
                        effects = datas[i].Split(',');
                        break;
                    case 4:
                        buffer = datas[i].Split(',');
                        j = 0;
                        while (j < 3)
                        {
                            intbuffer[j] = int.Parse(buffer[j]);
                            j++;
                        }
                        cStuffRatio = intbuffer;
                        break;
               }
               i++;
           }
        }
        public int getNumber()
        {
            return cNumber;
        }
        public char getRank() 
        {
            char[] buffer = cRank.ToCharArray();
            return buffer[0];
        }
        public String getName()
        {
            return cName;
        }
        public String[] getStuff()
        {
            return cStuff;
        }
        public String getStuffForString()
        {
            String buffer = "";
            for (int i = 0; i < cStuff.Length; i++)
            {
                buffer += cStuff[i];
                if (i < 2) buffer += " / ";
            }
            return buffer;
        }
        public String getEffect()
        {
            String buffer = "";
            for (int i = 0; i < effects.Length; i++)
            {
                buffer += effects[i];
                buffer += " ";
            }
            return buffer;
        }
        public int[] getRatio()
        {
            return cStuffRatio;
        }
    }
    public class Node
    {
        private Cook NodeData;
        private Node pNext;
        public Node(Cook data)
        {   // 노드를 생성할때 바로 요리 정보를 넣어버린다.
            this.NodeData = data;
            this.pNext = null;
        }
        public Cook getNodeData()
        {
            return NodeData;
        }
        public Node getNextNode()
        {
            return pNext;
        }
        public Node setNextNode(Cook data)
        {   // pNext에 새로운 개체를 생성해서 붙이기
            pNext = new Node(data);
            return pNext;
        }
    }
    public class Queue
    {
        private Node pService;
        private Node pCurrent;
        private int queueLength;
        public Queue()
        {
            pService = null;
            pCurrent = null;
            queueLength = 0;
        }
        public int getQueueLength()
        {
            return queueLength;
        }
        public void waitNodeAdd(Cook data)
        {
            if (pCurrent == null)
            {
                pCurrent = new Node(data);
                pService = pCurrent;
            }
            else pCurrent = pCurrent.setNextNode(data);
            queueLength++;
        }
        public Cook serviceNode()
        {
            if (queueLength == 0) return null;
            else
            {
                Node buffer = pService;
                pService = pService.getNextNode();  // 남은 데이터 처리는.. 알아서 해주나? ;;
                queueLength--;
                return buffer.getNodeData();
            }
        }
    }
}
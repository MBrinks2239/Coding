﻿using System;

namespace IPv4_validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValidIP("12.255.56.1").ToString());
        }

        public static bool IsValidIP(string IP)
        {
            int[] dotLoc = new int[3];
            int e = 0;
            for (int i = 0;i<IP.Length;i++){
                if(IP[i].ToString()=="."){
                    try{
                        dotLoc[e] = i;
                    }
                    catch{
                        return false;
                    }
                    e++;
                }
                if(IP[i].ToString()=="."||IP[i].ToString()=="0"||IP[i].ToString()=="1"||IP[i].ToString()=="2"||IP[i].ToString()=="3"||IP[i].ToString()=="4"||IP[i].ToString()=="5"||IP[i].ToString()=="6"||IP[i].ToString()=="7"||IP[i].ToString()=="8"||IP[i].ToString()=="9"){
                    
                } else{
                    return false;
                }
            }
            try{
                if(Convert.ToInt32(IP.Substring(0, dotLoc[0])[0])==0){
                    return false;
                }
                if(Convert.ToInt32(IP.Substring(dotLoc[0]+1, dotLoc[1]-dotLoc[0]-1)[0])==48){
                    return false;
                }
                if(Convert.ToInt32(IP.Substring(dotLoc[1]+1, dotLoc[2]-dotLoc[1]-1)[0])==48){
                    return false;
                }
                if(Convert.ToInt32(IP.Substring(dotLoc[2]+1, IP.Length-dotLoc[2]-1)[0])==48){
                    return false;
                }
            
                if(!(Convert.ToInt32(IP.Substring(0, dotLoc[0]))<=255&&Convert.ToInt32(IP.Substring(0, dotLoc[0]))>=0)){
                    return false;
                }
                if (!(Convert.ToInt32(IP.Substring(dotLoc[0]+1, dotLoc[1]-dotLoc[0]-1))>=0&&Convert.ToInt32(IP.Substring(dotLoc[0]+1, dotLoc[1]-dotLoc[0]-1))<=255)){
                    return false;
                }
                if(!(Convert.ToInt32(IP.Substring(dotLoc[1]+1, dotLoc[2]-dotLoc[1]-1))>=0&&Convert.ToInt32(IP.Substring(dotLoc[1]+1, dotLoc[2]-dotLoc[1]-1))<=255)){
                    return false;
                }
                if(!(Convert.ToInt32(IP.Substring(dotLoc[2]+1, IP.Length-dotLoc[2]-1))>=0&&Convert.ToInt32(IP.Substring(dotLoc[2]+1, IP.Length-dotLoc[2]-1))<=255)){
                    return false;
                }
            }
            catch{
                return false;
            }
            return true;
        }
    }
}

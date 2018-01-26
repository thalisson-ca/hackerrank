using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int h = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        
        Dictionary<int,string> hour = new Dictionary<int,string>();
        hour.Add(1,"one");
        hour.Add(2,"two");
        hour.Add(3,"three");
        hour.Add(4,"four");
        hour.Add(5,"five");
        hour.Add(6,"six");
        hour.Add(7,"seven");
        hour.Add(8,"eight");
        hour.Add(9,"nine");
        hour.Add(10,"ten");
        hour.Add(11,"eleven");
        hour.Add(12,"twelve");
        
        Dictionary<int,string> minutes = new Dictionary<int,string>();
        minutes.Add(0," o' clock");
        minutes.Add(1,"one minute past ");
        minutes.Add(2,"two minutes past ");
        minutes.Add(3,"three minutes past ");
        minutes.Add(4,"four minutes past ");
        minutes.Add(5,"five minutes past ");
        minutes.Add(6,"six minutes past ");
        minutes.Add(7,"seven minutes past ");
        minutes.Add(8,"eight minutes past ");
        minutes.Add(9,"nine minutes past ");
        minutes.Add(10,"ten minutes past ");
        minutes.Add(11,"eleven minutes past ");
        minutes.Add(12,"twelve minutes past ");
        minutes.Add(13,"thirteen minutes past ");
        minutes.Add(14,"fourteen minutes past ");
        minutes.Add(15,"quarter past ");
        minutes.Add(16,"sixteen minutes past ");
        minutes.Add(17,"seventeen minutes past ");
        minutes.Add(18,"eighteen minutes past ");
        minutes.Add(19,"nineteen minutes past ");
        minutes.Add(20,"twenty minutes past ");
        minutes.Add(21,"twenty one minutes past ");
        minutes.Add(22,"twenty two minutes past ");
        minutes.Add(23,"twenty three minutes past ");
        minutes.Add(24,"twenty four minutes past ");
        minutes.Add(25,"twenty five minutes past ");
        minutes.Add(26,"twenty six minutes past ");
        minutes.Add(27,"twenty seven minutes past ");
        minutes.Add(28,"twenty eight minutes past ");
        minutes.Add(29,"twenty nine minutes past ");
        minutes.Add(30,"half past ");
        minutes.Add(31,"twenty nine minutes to ");
        minutes.Add(32,"twenty eight minutes to ");
        minutes.Add(33,"twenty seven minutes to ");
        minutes.Add(34,"twenty six minutes to ");
        minutes.Add(35,"twenty five minutes to ");
        minutes.Add(36,"twenty four minutes to ");
        minutes.Add(37,"twenty three minutes to ");
        minutes.Add(38,"twenty two minutes to ");
        minutes.Add(39,"twenty one minutes to ");
        minutes.Add(40,"twenty minutes to ");
        minutes.Add(41,"nineteen minutes to ");
        minutes.Add(42,"eighteen minutes to ");
        minutes.Add(43,"seventeen minutes to ");
        minutes.Add(44,"sixteen minutes to ");
        minutes.Add(45,"quarter to ");
        minutes.Add(46,"fourteen minutes to ");
        minutes.Add(47,"thirteen minutes to ");
        minutes.Add(48,"twelve minutes to ");
        minutes.Add(49,"eleven minutes to ");
        minutes.Add(50,"ten minutes to ");
        minutes.Add(51,"nine minutes to ");
        minutes.Add(52,"eight minutes to ");
        minutes.Add(53,"seven minutes to ");
        minutes.Add(54,"six minutes to ");
        minutes.Add(55,"five minutes to ");
        minutes.Add(56,"four minutes to ");
        minutes.Add(57,"three minutes to ");
        minutes.Add(58,"two minutes to ");
        minutes.Add(59,"one minute to ");
        
        if(m>30){
            h++;
        }
        if(m==0){
            Console.WriteLine(hour[h]+minutes[m]);
        }else{
            Console.WriteLine(minutes[m]+hour[h]);
        }
    }
}

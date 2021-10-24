using System;
using System.Collections.Generic;
using System.Text;

namespace LooselyCoupled
{
  public  class Computer
    {
        public IMemoryUnit Ram { get; set; } //bagımlılık depenceny
        public IStorageDevice Disk { get; set; }

    }


    public interface IMemoryUnit
    {

    }
    public interface IStorageDevice
    {

    }




    public class Ram:IMemoryUnit
    {
        int Capacity { get; set; }
        public string  Vender { get; set; }

    }
    public class  HardDisk :IStorageDevice
    {
        public int RPM { get; set; }
    }

    public class SSD : IStorageDevice
    {

    }


}

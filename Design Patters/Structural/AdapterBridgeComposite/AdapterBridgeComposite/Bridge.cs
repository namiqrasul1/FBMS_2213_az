using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgee
{
    public interface IDevice
    {
        bool IsEnabled { get; set; }
        short Volume { get; set; }
        short Channel { get; set; }
    }

    public class TV : IDevice
    {
        public bool IsEnabled { get; set; }
        public short Volume { get; set; }
        public short Channel { get; set; }
    }

    public class Radio : IDevice
    {
        public bool IsEnabled { get; set; }
        public short Volume { get; set; }
        public short Channel { get; set; }
    }

    public class RemoteController
    {
        public IDevice Device { get; set; }

        public RemoteController(IDevice device)
        {
            Device = device;
        }

        public void TogglePower() { Device.IsEnabled = !Device.IsEnabled; }

        public void VolumeUp()
        {
            Device.Volume += 10;
            if (Device.Volume >= 100) Device.Volume = 100;
        }

        public void VolumeDown()
        {
            Device.Volume -= 10;
            if (Device.Volume <= 0) Device.Volume = 0;
        }

        public void ChannelUp() { Device.Channel += 1; }

        public void ChannelDown() { Device.Channel -= 1; }
    }

    public class Bridge
    {
        static void Main2(string[] args)
        {
            TV tv = new();

            RemoteController remote = new(tv);


            Console.WriteLine(tv.IsEnabled);
            remote.TogglePower();
            Console.WriteLine(tv.IsEnabled);
            Console.WriteLine(tv.Volume);
            remote.VolumeUp();
            remote.VolumeUp();
            Console.WriteLine(tv.Volume);
            remote.VolumeDown();
            Console.WriteLine(tv.Volume);
            Console.WriteLine(tv.Channel);
            remote.ChannelUp();
            Console.WriteLine(tv.Channel);

        }



    }
}

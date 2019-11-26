using System;
namespace DemoApp
{

    // Set Interface for Delegate
    public interface SendBackDelegate
    {


        void sendBackData();
    }

    public class SampleDelegates
    {

        SampleDelegateUse showListObj = new SampleDelegateUse();
        SendBackDelegate delegate = showListObj;

        public SampleDelegates()
        {
        }
    }
}

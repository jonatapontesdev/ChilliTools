using System;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPRagTools.Utils
{
    public class _JPThread
    {
        private Thread thread;


        public _JPThread(Func<int, int> toRun)
        {
            this.thread = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        toRun(0);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("[JPThread Exception] Erro ao executar o método Thread ==== " + ex.Message);
                    }
                    finally
                    {
                        Thread.Sleep(5);
                    }
                }
            });
            this.thread.SetApartmentState(ApartmentState.STA);
        }

        public static void Start(_JPThread _JPThread)
        {
            _JPThread.thread.Start();
        }

        public static void Stop(_JPThread _JPThread)
        {
            if (_JPThread != null && _JPThread.thread.IsAlive)
            {
                try
                {

                    _JPThread.thread.Suspend();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[JPThread Exception] =========== Não foi possível suspender o thread atual: " + ex);
                }
            }
        }
    }
}

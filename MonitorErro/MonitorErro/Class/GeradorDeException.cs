using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorErro.Class
{
    enum tpException
    {
        ArgumentException,
        ArgumentNullException,
        ArgumentOutOfRangeException,
        DivideByZeroException,
    }

    public class GeradorDeException
    {
        Random random = new Random();

        public GeradorDeException()
        {
			//teste vitor parte 1
        }

        public void GetException()
        {
            switch (random.Next(Enum.GetNames(typeof(tpException)).Length))
            {
                case (int)tpException.ArgumentException:
                    throw new ArgumentException();
                    break;
                case (int)tpException.ArgumentNullException:
                    throw new ArgumentNullException();
                    break;
                case (int)tpException.ArgumentOutOfRangeException:
                    throw new ArgumentOutOfRangeException();
                    break;
                case (int)tpException.DivideByZeroException:
                    throw new DivideByZeroException();
                    break;
                default:
                    throw new Exception();
                    break;
            }
        }

    }
}

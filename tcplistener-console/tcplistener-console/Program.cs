/*    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace tcplistener_console
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Write("tcplistener by Hernan Ignacio vivani - 20110225 - http://hvivani.com.ar: \r\n");
            if (args.Length == 0)
            {
                System.Console.WriteLine("Parametros: Puerto <num> IP <xxx.xxx.xxx.xxx>  \r\n");
                System.Console.WriteLine("Ejemplo: tcplistener 2525 127.0.0.1  \r\n");
                System.Console.WriteLine("si tenes mas de una interfaz de red, usa la ip de dicha interfaz.  \r\n");
                return 1;
            }
            else
            {
                //unacnn.iniciar(args[0], args[1]);//mono puerto
                //multicnn.iniciar(args[0], args[1]);
                multicnnNew.iniciar(args[0], args[1]);
                return 0;
            }

        }  
    }
}

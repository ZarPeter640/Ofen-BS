using Ofen_BS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ofen_BS.ViewModel
{
    public class Validierung
    {
        private StartKnopf _startknopf = new StartKnopf();
        private Roehre _roehre = new Roehre();
        private Lampe _lampe = new Lampe();
        private Tuer _tuer = new Tuer();

        public void SicherheitsCheck()
        {
            if (!_tuer.offen)
            {
                _startknopf.drueckbar = true;
                _lampe.licht = true;
                _roehre.heiss = true;
            }
            else
            {
                _startknopf.drueckbar = false;
                _roehre.heiss = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BlueFlame.Classes.DatabaseObjects.Enums
{
    class Message
    {


        public string GetText(int key)
        {
            return "";
        } 

        private string GetGerman(int key)
        {
            switch(key)
            {
                //case 1000, 'CDerfolgreich erstellt'
                //1001, 'CD erstellen abgebrochen oder Fehler'
                //2001, 'Benutzer abgemeldet'
                //2003, 'Benutzer Anmeldefehler'
                //3000, 'Lizenz angefordert, neue Lizenz erteilt'
                //3001, 'Lizenz angefordert, alte Lizenz nochmal erteilt'
                //3002, 'Lizenz angefordert, keine Lizenz gefunden'
                //2002, 'Anmeldung Abgegrochen'
                //2004, 'Anmeldung Fehlgeschlagen, leerer Benutzername'
                //2000, 'Benutzer erfolgreich angemeldet'
            }
            return "";
        }
    }

  
}

# TCPEcos

TCP Ecos ist eine Konsolenapplikation zum direkten Ansteuerung der ESU ECoS 50210 Zentrale über die PC Schnittstelle.

**Dies ist kein offizielles Produkt von ESU, sondern eine Communityversion**

# Programm.cs

Das Hauptprogramm steuert den EcosLeser.cs und EcosSchreiber.cs an und erlaubt es dadurch,
dass man die Befehle von der ECoS Schnittstellendokumentation direkt eingeben kann und daraufhin die Antwort der Zentrale erhält.
Anfangs muss bei Start des Programms noch die IP Adresse der ECoS Station eingegeben werden.
Diese kann in der Zentrale selbst ausgelesen werden -> siehe offizielles Handbuch.
Das Programm wird nur bei einem Fehler abgebrochen.

# EcosLeser.cs

Tut im Prinzip, was sein Name sagt. Er liest alle erhaltenen Nachrichten der ECoS aus und schreibt sie in die Konsole.

# EcosSchreiber.cs

Schickt sämtliche Befehle an die ECoS, sobald die ENTER Taste gedrückt wurde. Normalerweise akzeptiert die ECoS auf diese Weise nur immer einen Befehl.
Wird "esc" oder "ende" eingegeben, wird die Verbindung getrennt.

# LokBeispiel.cs

Demonstriert, wie man eine Lok über die Schnittstelle fernsteuern könnte.
Zuerst werden die Werte der Lokomotive abgefragt, anschliessend werden einige Funktionen aktiviert (Licht, Sound, etc.).
Dann wird die Geschwindigkeit/Motorenstufe auf 127 gesetzt (dies war bei meiner Lok die Höchste Stufe, kann aber bei anderen anders sein!)
und anschliessend nach einem Timer nach und nach verringert, bis die Stufe wieder auf 0 ist.
Anschliessend werden alle Funktionen wieder ausgeschaltet.
Das LokBeispiel.cs wird nicht vom Programm angesteuert, du kannst es aber einfach einfügen und so ausprobieren.
Stelle aber sicher, dass deine Lok die richtige ID, wenn du diese Klasse aufrufst!

# Netzwerkspezifikation_2023.pdf // Stand Juli 2023

[Eine noch unvollständige Dokumentation](https://github.com/TabalugaDrache/TCPEcos/blob/9ec2f93a858db12ac14ed0fec42ff09aa5f16a7c/Netzwerkspezifikation_2023.pdf) , welche ich aus der offiziellen Dokumentation von 2011 und der übersetzten Dokumentation auf der Station zusammengetragen haben.
Es sind noch nicht alle Befehle und Objekte dokumentiert, sie gibt aber schon einmal einen guten Überblick. 

_Seit dem Juli ist bereits ein neuer Patch für die ECoS erschienen, dieser ist noch nicht dokumentiert._

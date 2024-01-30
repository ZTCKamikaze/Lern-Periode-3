# Lern-Periode 3

Mika Olmes

9.1.2024 bis 30.1.2024 (☃️ Sportferien)

## Grob-Planung

1. M164: 5.0, M319: 5.0, M431: 5.0 Ich finde das das Modul 319 eines der wichtigsten Module ist, da es das Grundmodul aller Programmierprojekte ist.
2. Ich hatte mir vorgenommen ein Tetris Spiel zu programmieren, aber ich habe es nicht zu Ende programmieren können. Ich hatte zwei VBV und zwar eimnmal das Modul 319 repetieren, und konzentrierter arbeiten, nicht so schnell ablenken lassen. Das Modul 319 zu repetieren könnte ich ganz einfach machen indem ich alle Präsentationen nochmals anschaue und ein paar Aufgaben mache.
3. Ich würde gerne einen Currency berechner machen im Windows Forms (nur die 5 wichtigsten, da nicht so viel Zeit zur Verfügung steht).

## 9.1.2024

✍️ Heute habe ich mal geschaut was ich machen möchte. Zuerst wollte ich einen Vokavel Trainer für Japanische Grundwörter machen, doch ich habe ziemlich schnell gemerkt, dass es nicht so einfach für mich ist, darum habe ich nochmals nachgedacht was ich sonst machen könnte. Am Schluss bin ich dazu gekommen, dass ich einen Currency-Converter machen möchte. Aber ich weiss noch nicht genau ob ich das schaffen werde. (66 Wörter)

## 16.1.2024

- [X] Die 5 wichtigsten Währungen eingetragen
- [X] Die 5 Währungen unter einem Button erklärt (Bsp. EUR = Euro oder CHF = Schweizer Franken)
- [X] Beziehungen zwischen den Währungen herausfinden (am besten mit einer Tabelle als Notiz)
- [X] Die Beziehungen in den Code einführen 

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --- | --- | --- | --- | --- |
| 1   |Programm in Visual Studio gestartet|EUR auswählen|Box heisst jetzt EUR|  JA   |
| 2   |Programm in Visual Studio gestartet|Button drücken|Messagebox mit erklärten Begriffen |  JA  |
| 3   |Programm in Visual Studio gestartet|Button drücken|Messagebox mit den Kursen     |  JA  |
| 4   |Programm in Visual Studio gestartet|     |     |     |

✍️ Heute habe ich Die 5 Wichtigsten Währungen herausgefunden und diese dann in den Code eingeführt (noch nicht kokplett), die Währungskürzel werden unter einem Button erklärt und dazu habe ich noch die Kurse herausgesucht und auch gefunden, jetzt müssen diese in den Code rein, aber ich weiss noch nicht wie. (50 Wörter)

☝️ Vergessen Sie nicht, bis zum 16.1 einen ersten Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt

## 23.1.2024

- [X] Alle Währungen sollten ausgerechnet werden
- [X] Es soll negative Zahlen als ungültig erkennnen (sowohl auch Buchstaben) und komma zahlen als gültig
- [X] Einen Button der das Programm beendet
- [ ] Wenn noch zeit ist: Designe anpassen oder mehr Währungen einfügen.
  

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --- | --- | --- | --- | --- |
| 5   |Programm in Visual Studio gestartet| USD 10 - EUR |  USD 10 - EUR 9.20  |   JA  |
| 6   |Programm in Visual Studio gestartet|   -23 EUR - 2 CHF  |   Falsche Eingabe  |   NEIN  |
| 7   |Programm in Visual Studio gestartet|  Button drücken   |  Programm wird beendet   |  JA   |
| 8   |Programm in Visual Studio gestartet|abc|Flasche Eingabe|  JA   |

✍️ Heute habe ich gerausgefunden wie ich die berechnungen machen kann, und zwar mit Switch Cases, die wollte ich heute auch noch hinzufügen, doch leider habe ich 2 Fehler und weiss nicht wie ich diese Lösen soll. Ich werde unter der Woche und am Wochenende probieren den Code fertig zu machen, den Code den ich bis jetzt habe lade ich Ihnen noch hoch. (62 Wörter)

✍️ Heute (24.1.2024) hatte ich sehr viel ausfall, und da habe ich am Code weitergearbeitet, und habe meine 2 Fehler von gestern behoben, doch nun bin ich auf einen neuen Fehler gestossen, und zwar kann ich mit einem decimal und double nicht * rechnen, ich muss diesen Fehler beheben, weiss aber noch nicht wie. Ich lade den Code erneut hoch. (59 Wörter)

✍️ Heute (28.01.2024) habe ich meinen Code zu ende bekommen, er kann jetzt 5 Währungen berechnen, das Programm mit einem Button beenden, Abkürzungen mithilfe eines Buttons erklären und die Kurse der Währungen ebenfalls mit einem Button erklären. Er erkennt auch falsche Eingaben wie Buchstaben, leider erkennt er keine Minus Zahlen. Den Code werde ich Ihnen erneut hochladen. (56 Wörter)

☝️ Vergessen Sie nicht, bis zum 23.1 Ihren fixfertigen Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt

## 30.1.2024

✍️ Heute am 30.01.2024 habe ich meinen Code gesäubert und darüber vieles gelernt wie ich es besser machen kann und auch aus meinen eigenen Fehlern gelernt, dazu habe ich noch mein GitHub Profil besser gestaltet und auch gelernt was man alles noch so mit GitHub machen kann (Website erstellen). Zu guter Letzt habe ich noch eine Reflexion geschrieben. (57 Wörter)

## Reflexion

Formen Sie Ihre Zusammenfassungen in Hinblick auf Ihren VBV zu einem zusammenhängenden Text von 100 bis 200 Wörtern (wieder mit Angabe in Klammern).

Diesesmal hatte ich gut und konzentriert arbeiten können und sogar meinen Code fertig bekommen, ich hatte zwar hin und wieder ein paar Probleme, doch ich habe mir diese Probleme vorgenommen und konnte sie so auch lösen, weil ich nicht einfach aufgegeben habe sondern immer weiter veruscht habe das Problem zu lösen. Ich bin sehr zufrieden mit meinem Programm, doch leider ist der Code nicht ganz Übersichtlich gestalltet, für das nächste mal nehme ich mir vor den Code und die Namen der Variabeln und Funktionen besser zu Überlegen. Was ich in Zukunft noch machen könnte wäre es weitere Währungen hinzuzufügen, denn gerade habe ich nur 5 Währungen. (106 Wörter)

Verfassen Sie zusätzlich einen kurzen Abschnitt, in welchem Sie über die Länge der Projekte reflektieren: Fanden Sie die 9-wöchtige LP2 oder die 4-wöchige LP3 angenehmer? Was bedeutet das für Ihre Planung der zukünftigen LP?

Ich finde das beide Vorgeghensweisen ihre Nachteile und Vorteie haben, in der LP2 fande ich es gut etwas selber zu machen was mit Informatik zu tun hat (M319), aber es war nicht so spannend und wir mussten oft in die Schule kommen. Die LP3 hat mir glaube ich ein kleines bisschen mehr Spass gemacht, denn ich konnte ein Code von Grund auf neu erstellen und diesen dann auch zu vollenden, das ich nicht in die Schule musste und zu Hause in Ruhe an meinem Code arbeiten konnte war sehr cool. Das einzige was mich ein klein wenig gestört hat, war, das wir nicht so viel Zeit hatten, aber am Schluss habe ich es noch geschafft. (115 Wörter)

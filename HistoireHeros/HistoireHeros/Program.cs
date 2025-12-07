var Titus = new Krakote();
Console.WriteLine();

Titus.Step1();
if (Titus.PlayerAnswer == 1)
{
    Titus.Step2();
    if (Titus.PlayerAnswer == 1)
    {
        Titus.Step31();
        if (Titus.PlayerAnswer == 1)
        {
            Titus.Step2();
        }
    }
    if(Titus.PlayerAnswer == 2)
    {
        Titus.Step32();
        if (Titus.PlayerAnswer == 1)
        {
            Titus.Step321();
        }
        if (Titus.PlayerAnswer == 2)
        {
            Titus.Step322();
        }
    }
    Titus.Step4();
    if (Titus.PlayerAnswer == 1)
    {
        Titus.StepWindUp();
        if (Titus.Blessure == 0);
        {
            Titus.Step5S();
        }
        if (Titus.PlayerAnswer == 1)
        {
            Titus.Step5G();
            if (Titus.PlayerAnswer == 1);
            {
                Titus.Step5G1();
            }
            if (Titus.PlayerAnswer == 2);
            {
                Titus.Step5G2();
            }
            if (Titus.PlayerAnswer == 3);
            {
                Titus.Step5G3();
                if (Titus.PlayerAnswer == 1);
                {
                    Titus.Step5G31();
                }
                if (Titus.PlayerAnswer == 2);
                {
                    Titus.Step5G32();
                    Titus.Step5G31();
                }
            }
        }
    }
    if (Titus.PlayerAnswer == 2)
    {
        if(Titus.Engrenage == 0)
        {
            Titus.Step5FN();
            Titus.StepWindUp();
        if (Titus.Blessure == 0);
        {
            Titus.Step5S();
        }
        if (Titus.PlayerAnswer == 1)
        {
            Titus.Step5G();
            if (Titus.PlayerAnswer == 1);
            {
                Titus.Step5G1();
            }
            if (Titus.PlayerAnswer == 2);
            {
                Titus.Step5G2();
            }
            if (Titus.PlayerAnswer == 3);
            {
                Titus.Step5G3();
                if (Titus.PlayerAnswer == 1);
                {
                    Titus.Step5G31();
                }
                if (Titus.PlayerAnswer == 2);
                {
                    Titus.Step5G32();
                    Titus.Step5G31();
                }
            }
        }
        }
        if(Titus.Engrenage == 1)
        {
            Titus.Step5FO();
            if (Titus.PlayerAnswer == 1)
            {
                Step5FO1();
            }
            if (Titus.PlayerAnswer == 2)
            {
                Titus.StepWindUp();
        if (Titus.Blessure == 0);
        {
            Titus.Step5S();
        }
        if (Titus.PlayerAnswer == 1)
        {
            Titus.Step5G();
            if (Titus.PlayerAnswer == 1);
            {
                Titus.Step5G1();
            }
            if (Titus.PlayerAnswer == 2);
            {
                Titus.Step5G2();
            }
            if (Titus.PlayerAnswer == 3);
            {
                Titus.Step5G3();
                if (Titus.PlayerAnswer == 1);
                {
                    Titus.Step5G31();
                }
                if (Titus.PlayerAnswer == 2);
                {
                    Titus.Step5G32();
                    Titus.Step5G31();
                }
            }
        }
            }
        }
    }
    Titus.Step6();
    if (Titus.PlayerAnswer == 1)
    {
        Titus.Step6F();
        if (Titus.Piece == 0);
        {
            Titus.Step6FN();
            if (Titus.PlayerAnswer == 1)
            {
                Titus.Step6F1();
                Titus.Step6M();
                if (Titus.PlayerAnswer == 1)
                {
                    Titus.Step6M1();
                }
                if (Titus.PlayerAnswer == 2)
                {
                    if (Titus.Blessure == 1)
                    {
                        Titus.Step6M2B();
                    }
                    if (Titus.Blessure == 0)
                    {
                        Titus.Step6M2S();
                    }
                }
            }
            if (Titus.PlayerAnswer == 2)
            {
                Titus.Step6F3();
            }
        }
        if (Titus.Piece == 1);
        {
            Titus.Step6FO();
            if (Titus.PlayerAnswer == 1)
            {
                Titus.Step6F1();
            }
            if (Titus.PlayerAnswer == 2)
            {
                Titus.Step6F2();
            }
            if (Titus.PlayerAnswer == 3)
            {
                Titus.Step6F3();
            }
        }
    }
    if (Titus.PlayerAnswer == 2);
    {
        Titus.Step6M();
            if (Titus.PlayerAnswer == 1)
            {
                Titus.Step6M1();
            }
            if (Titus.PlayerAnswer == 2)
            {
                if (Titus.Blessure == 1)
                {
                    Titus.Step6M2B();
                }
                if (Titus.Blessure == 0)
                {
                    Titus.Step6M2S();
                }
            }
    }
}
if (Titus.PlayerAnswer == 2)
{
    Titus.Answer1();
}


public class Krakote
{
    public int PlayerAnswer;
    public int Engrenage = 0;
    public int Blessure = 0;
    public int Piece = 0;

    public int Step1()
    {
        Console.WriteLine("Vous êtes à l'entrée du donjon, prêt à forger votre légende d'aventurier.");
        Console.WriteLine("Entrez '1' pour entrer. Entrez '2' pour faire demi tour.");
        PlayerAnswer = (int.Parse(Console.Readline()));
        return PlayerAnswer;
    }

    public int Step2()
    {
        Console.WriteLine("Vous ouvrez la porte du donjon et entrez.");
        Console.WriteLine("Deux portes se trouvent devant vous. Laquelle voulez vous ouvrir ?");
        Console.WriteLine("Entrez '1' pour pour celle de gauche et '2' pour celle de droite.");
        PlayerAnswer = (int.Parse(Console.Readline()));
        return PlayerAnswer;
    }

    public int Answer1()
    {
        Console.WriteLine("Vous rentrez chez vous en vous disant que tout ça est stupide.");
    }

    public int Step31()
    {
        Console.WriteLine("Une salle avec un coffre. Vous l'ouvrez et trouvez un gros engrenage. Une porte permet d'aller plus loin.");
        Console.WriteLine("Entrez '1' pour avancer ou '2' pour faire demi tour.");
        PlayerAnswer = (int.Parse(Console.Readline()));
        Engrenage ++;
        return PlayerAnswer;
    }

    public int Step32()
    {
        Console.WriteLine("Une salle avec un squelette armé d'un arc ! Au combat !");
        Console.WriteLine("Entrez '1' pour donner un coup d'épée ou '2' pour bloquer avec l'épée.");
        PlayerAnswer = (int.Parse(Console.Readline()));
        return PlayerAnswer;
    }

    public int Step321()
    {
        Console.WriteLine("Vous terrassez le squelette et avancez dans la salle suivante.");
    }

    public int Step322()
    {
        Console.WriteLine("Quelle idée que de tentr de bloquer une flèche avec une épée ?");
        Console.WriteLine("Vous subissez une blessure avant de mettre un coup fatal au monstre");
        Blessure ++;
        return Blessure;
    }

    public int Step4()
    {
        Console.WriteLine("Vous voilà dans une salle avec un grand gouffre qui vous bloque passage.");
        Console.writeLine("De l'autre côté se trouve une porte en bois au dessus de laquelle brûle une torche.");
        Console.WriteLine("Entrez '1' pour tenter de sauter par dessus le gouffre ou '2' pour fouiller comme vous pouvez");
        PlayerAnswer = (int.Parse(Console.Readline()));
        return PlayerAnswer;
    }

    public int StepWindUp()
    {
        Console.WriteLine("Vous prenez votre élan et...");
    }
    
    public int Step5G()
    {
        Console.WriteLine("Vous pensiez pouvoir le faire, mais c'était sans compter sur votre blessure.");
        Console.WriteLine("Vous ne franchissez pas la moitié de la distance avant de tomber. La chute est longue mais alors que vous croyez vous écraser, vous êtes doucement ralenti par la magie.");
        Console.writeLine("Vous avez atterri dans une salle cachée ! Devant vous se trouve trois portes.");
        Console.WriteLine("Au dessus de chacune est inscrit une indication : 'Méchant dragon' pour celle de gauche, 'pics empoisonnés' pour celle du centre et 'lions qui n'ont pas mangé depuis 1 mois' au dessus de celle de droite.");
        Console.WriteLine("Entrez '1' pour ouvrir la porte du dragon, entrez '2' pour celle des pics ou '3' pour celle des lions.");
        PlayerAnswer = (int.Parse(Console.Readline()));
        return PlayerAnswer;
    }

    public int Step5G1()
    {
        Console.WriteLine("Vous ouvrez la porte du dragon. Immédiatement, un mur de flammes s'écrase sur vous. Vous mourrez sur le coup. Pas de chance. Quelle idée de tenter de combattre un dragon, aussi ?");
    }

    public int Step5G2()
    {
        Console.WriteLine("Vous ouvrez la porte et, du mur juste derrière la porte, des pieux couverts de poisons jaillissent. Il est probable que si vous n'aviez pas fini empalé, le poison aurait eu raison de vous. ");
    }

    public int Step5G3()
    {
        Console.WriteLine("Que ce soit par chance ou par votre réflexion, vous avez ouvert ce qui semble être la bonne porte.");
        Console.WriteLine("Les lions sont morts de faim il y a longtemps, ne laissant derrière eux que des ossements.");
        Console.WriteLine("Quelques mètres plus loin, vous voyez une cage d'escaliers qui semble monter. En haut de ses escaliers, un mur et un levier.");
        Console.WriteLine("Entrez '1' pour tirer sur le levier ou '2' pour fouiller la zone.");
        PlayerAnswer = (int.Parse(Console.Readline()));
        return PlayerAnswer;
    }

    public int Step5G31()
    {
        Console.WriteLine("Vous tirez le levier et le mur devant les escaliers s'abaisse en grondant.");
    }

    public int Step5G32()
    {
        Console.WriteLine("Vous fouillez au mieux de vos capacités, mais vous ne trouvez rien d'autre qu'une pièce d'or, pas même dans la salle des lions.");
        Console.WriteLine("Vous n'avez d'autre choix que de tirer le levier.");
        Piece++;
        return Piece;
    }

    public int Step5S()
    {
        Console.WriteLine("Grâce à votre forme physique exceptionnelle vous parvenez à sauter par dessus le gouffre. Vous arrivez devant la porte et l'ouvrez.");
    }

    public int Step5FN()
    {
        Console.WriteLine("Après une fouille minutieuse, vous trouvez, le long de la paroi du gouffre, un trou de la forme d'un engrenage. Malheureusement, vous ne pouvez rien en faire.");
    }

    public int Step5FO()
    {
        Console.WriteLine("Après une fouille minutieuse, vous trouvez, le long de la paroi du gouffre, un trou de la forme d'un engrenage. Il a la même forme que celui que vous avez trouvé.");
        Console.Writeline("Entrez '1' pour tenter d'insérer l'engrenage ou '2' pour tout de même sauter.");
        PlayerAnswer = (int.Parse(ConsoleReadline()));
        return PlayerAnswer;
    }

    public int Step5FO1()
    {
        Console.WriteLine("Vous insérez l'engrenage, qui s'enfonce immédiatement dans la paroi hors de votre vision.");
        Console.WriteLine("Vous entendez un mécanisme se mettre en route avant qu'un pont ne commence à se déployer de la paroi opposée.");
        Console.WriteLine("Vous pouvez maintenant traverser en toute sécurité. Vous arrivez devant la porte et l'ouvrez.");
    }

    public int Step6()
    {
        Console.WriteLine("Devant vous se décvoile une pièce bien éclairée. Au centre se trouve un petit bassin d'eau claire.");
        Console.WriteLine("De l'autre côté de la pièce se trouve une autre porte.");
        Console.WriteLine("Entrez '1' pour examiner le bassin ou '2' pour aller directement à la porte.");
        PlayerAnswer = (int.Parse(ConsoleReadline()));
        return PlayerAnswer;
    }

    public int Step6F()
    {
        Console.WriteLine("Vous vous penchez sur la fontaine...");
    }

    public int Step6FO()
    {
        Console.WriteLine("En examinant la fontaine vous remarquez d'autres pièces similaires à celle que vous avez ramassé. Que voulez vous faire ?");
        Console.WriteLine("Entrez '1' pour ne rien faire, '2' pour jeter la pièce que vous avez ramassé plus tôt dedans ou '3' pour tenter de ramasser les pièces au fond du bassin.");
        PlayerAnswer = (int.Parse(ConsoleReadline()));
        return PlayerAnswer;
    }

    public int Step6FN()
    {
        Console.WriteLine("Des pièces d'or brillent d'un magnifique éclat au fond de l'eau. Que voulez vous faire ?");
        Console.WriteLine("Entrez '1' pour ne rien faire ou '2' pour tenter de ramasser les pièces au fond du bassin.");
        PlayerAnswer = (int.Parse(ConsoleReadline()));
        return PlayerAnswer;
    }

    public int Step6F1()
    {
        Console.WriteLine("Vous laissez cette fontaine sans intérêt pour vous pencher sur cette porte.");
    }

    public int Step6F2()
    {
        Console.WriteLine("Vous prenez la pièce que vous avez ramassé plus tôt pour la jeter dans le bassin après l'avoir embrassé, espérant que cela vous apporte de la chance pour le reste du donjon. ");
        Console.WriteLine("Vous entendez une voix résonner quand la pièce touche le fond du bassin 'J'honore votre piété et votre générosité. Prenez ceci en gage de mon respect.'");
        Console.WriteLine("Un coffre rempli à ras bord de pièces d'or apparait devant vous. Fasciné, vous attrapez les poignées sur ses côtés pour le soulever. Quand vous terminez de vous relever, vous êtes revenu devant le donjon. Voilà une expédition des plus fructueuses !");
    }

    public int Step6F3()
    {
        Console.WriteLine("Vous plongez votre bras dans le bassin et parvenez à attraper quelques pièces, avant de vous rendre compte que l'eau du bassin s'est étendue sur tout votre corps.");
        Console.WriteLine("Vous n'avez pas le temps de crier avant que l'eau ne vous recouvre le visage. Et c'est ainsi que vous êtes mort noyé par un bassin enchanté.");
    }

    public int Step6M()
    {
        Console.WriteLine("Vous vous approchez de la porte. Sans trop savoir pourquoi, vous avez l'impression de l'entendre respirer.");
        Console.WriteLine("C'est une mimique ! Entrez '1' pour la frapper avec votre épée ! Ou soyez plus raisonnable et évitez de faire du bruit en ouvrant simplement cette porte avec '2'.");
        PlayerAnswer = (int.Parse(ConsoleRead()));
        return PlayerAnswer;
    }

    public int Step6M1()
    {
        Console.WriteLine("Vous aviez raison ! Alors que vous frappez cette créature avec votre épée, elle pousse un couinement d'agonie avant de disparaitre en fumée.");
        Console.WriteLine("Derrière ce qui fut son déguisement vous trouvez un coffre repli à ras bord d'or.");
        Console.WriteLine("Fasciné, vous attrapez les poignées sur ses côtés pour le soulever. Quand vous terminez de vous relever, vous êtes revenu devant le donjon. Voilà une expédition des plus fructueuses !");
    }

    public int Step6M2B()
    {
        Console.WriteLine("Alors que vous vous approchez de la porte, elle change de forme rapidement et vous frappe avec un tentacule terminé par une pointe acérée.");
        Console.WriteLine("La blessure, couplée à celle que vous avez reçu plus tôt, vous est fatale.");
    }

    public int Step6M2S()
    {
        Console.WriteLine("Alors que vous vous approchez de la porte, elle change de forme rapidement et vous frappe avec un tentacule terminé par une pointe acérée. Heureusement, ce n'est pas suffisant pour vous tuer !");
        Console.WriteLine("Alors que vous ripostez contrecette créature avec votre épée, elle pousse un couinement d'agonie avant de disparaitre en fumée. Derrière ce qui fut son déguisement vous trouvez un coffre repli à ras bord d'or.");
        Console.WriteLine("Fasciné, vous attrapez les poignées sur ses côtés pour le soulever. Quand vous terminez de vous relever, vous êtes revenu devant le donjon. Voilà une expédition des plus fructueuses !");
    }
}
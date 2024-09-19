//This is the intro, where the premise is introduced, and the first choice is offered. Both have valid paths to success, but also several ways to either fail the mission or get killed.
//This particular intro is taken from Warhammer 40,000's first edition, and is basically the most succinct way to explain the setting to anyone unfamiliar. I could have done it in my own words, but it'd be fairly obvious it was just re-written in my own words, and would probably be less concise. I hope this isn't an issue.
Console.WriteLine("It is the 41st Millenium. For more than a hundred centuries, The Emperor has sat immobile on the Golden Throne of Earth. He is the master of Mankind by the will of the god, and master of a million worlds by the might of his inexhaustible armies. He is a rotting carcass writhing invisibly with power from the Dark Age of Technology. He is the Carrion Lord of the Imperium for whom a thousand souls are sacrificed every day, so that he may never truly die.\n");
Console.WriteLine("Yet even in his deathless state, the Emperor continues his eternal vigilance. Mighty battlefleets cross the daemon-infested miasma of the Warp, the only route between distant stars, their way lit by the Astronomican, the psychic manifestation of the Emperor's will. Vast armies give battle in his name on uncounted worlds. Greatest among his warriors are the Adeptus Astartes, the Space Marines, bio-engineered super-warriors. Their comrades in arms are legion; the Imperial Guard and countless planetary defense forces, the ever vigilant Inquisition and the tech-priests of the Adeptus Mechanicus to name only a few. But for all their multitudes, they are barely enough to hold off the ever-present threat from aliens, heretics, mutants - and worse.\n");
Console.WriteLine("To be a man in such times is to be one amongst untold billions. It is to live in the cruelest most bloody regime imaginable. These are the tales of those times. Forget the power of technology and science, for so much as been forgotten, never to be re-learned. Forget the promise of progress and understanding, for in the grim darkness of the far future, there is only war. There is no peace amongst the stars, only an eternity of carnage and slaughter, and the laughter of thirsting gods.\n");
Console.WriteLine("- Warhammer 40,000 - 1st Edition, a.k.a Rogue Trader\n\n");

//Getting the player's name. I phrased this hoping they'll use some sort of 40k-ish name, but it doesn't really matter at the end of the day. Also just using console.readline to get the input.
Console.WriteLine("What do your battle brothers call you?");
Console.WriteLine("(Please enter your name, Sergeant.)\n");
string Name = Console.ReadLine();

//Using string interpolation to fill in your character's name. 
Console.WriteLine($"\nYou are Sergeant {Name} of the Dark Angels chapter of the Adeptus Astartes, leading the 6th Squad of the 5th Company, serving under Master Lazarus. You are a veteran of the chapter, and a fearsome opponent for anyone that should oppose the Emperor's will.\n");
Console.WriteLine("You and your squad of veteran marines have been sent by direct order of Master Lazarus to head into a Necron Tomb World, and assassinate the Necron Overlord in charge before he is able to awaken his armies. You have been given explicit orders to avoid awakening the Necron tomb. If the tomb is awakened, the Dark Angels may be forced to order an exterminatus on the tomb world, essentially nuking the entire planet into oblivion before the Necrons can awaken, and start causing problems for the star system. This would result in the deaths of all of the Imperial Citizens on the planet, and would also destroy all of the precious resources the planet holds. Resources that the Imperium has great need for.\n");
Console.WriteLine("As soon as your squad is ready, you depart in a Thunderhawk gunship, piloted by one of your chapter's Techmarines, and head down to the planet's surface. On the surface, you find the large entrance to an ancient, gargantuan Necron tomb, and head inside. With the tomb still mostly inactive, you face little resistance, but take note of all of the sarcophagi and sealed-off rooms throughout the tomb.\n");

Console.WriteLine("Further into the tomb, after traveling for a  short while, you spot your first group of foes: a group of Necron Warriors. The rank and file Necron infantry units. They're about as weak as Necrons get besides the tiny Canoptek Scarabs, but they are still highly resilient, have the ability to repair damage, will teleport away when mortally wounded, and wield powerful gauss weapons that can pierce even Space Marine armor.\n\nThey haven't noticed your squad yet, but they are between you and your goal, and you'll need to deal with them somehow.\n\nHow are you going to approach this?\n\nOptions:");
Console.WriteLine("\"Head On\" - Attack them head on, and defeat them promptly in close combat.");
Console.WriteLine("\"Flank\" - Flank their position to take advantage of the element of surprise.");
Console.WriteLine("\nPlease enter which option you'd like to choose:\n");

//I don't know how to make the input case-insensitive, so I just added a note to users that their answers should follow the options given.
Console.WriteLine("(Note: Answers are case-sensitive)\n");
string Approach = Console.ReadLine();

//If they take the flanking approach, it branches off into this section where they'll have to decide between ranged or melee combat.
if (Approach == "Flank")
{
    Console.WriteLine("\nYou decide to flank the Necron Warriors in order to gain the element of surprise over the xenos infantry.");
    Console.WriteLine("\nHaving flanked them to get into a better positon to strike, you are ready to engage the enemy. All you must do now is decide on how you wish to approach this fight.");
    Console.WriteLine("\nHow do you wish to approach this battle?");
    Console.WriteLine("\nOptions:");
    Console.WriteLine("\"Bolt Rifles\" - You unleash the fury of the God-Emperor with your Cawl Pattern Bolt Rifles. The Necrons' weapons are deadly, even to Astartes, so perhaps staying at a distance will help avoid some of their fire.");
    Console.WriteLine("\"Power Swords\" - You go for direct melee combat with the Necron Warriors using your master-crafted Power Swords. Getting close can be risky, but Power Swords will slice through their necrodermis like butter.\n");

    string TacticsFlank = Console.ReadLine();

    if (TacticsFlank == "Power Swords")
    {
        Console.WriteLine("\nYou decide to get in close, and attack the Warriors with your master-crafted Power Swords.");
        Console.WriteLine("\nThe Necron Warriors are nothing for your Power Swords, and after a few moments, they lay in a pile of parts at you and your brothers' feet. Moments later, the parts begin to disappear, as Necrons will automatically teleport back to their crypts when damaged enough as a means of preserving the finite supply of troops the Necron dynasties have.");
        Console.WriteLine("\nAfter fighting the Warriors, you and your squad advance further into the tomb, passing through several gargantuan structures along the way. Further in, your squad uncovers something truly dangerous; an Annihilation Barge.");
        Console.WriteLine("\nThe Necrons like to use a lot of infantry, but they also possess a variety of vehicles within their armies, all serving different purposes, from infantry transport and artillery, to air support, stationary defenses, and main battle tanks. The Annihilation Barge is quite unconventional for a Main Battle Tank, but it offers tremendous firepower on a highly mobile hovering frame, and can certainly give Imperial tanks a run for their money.");
        Console.WriteLine("\nUpon seeing this vehicle, the thought crosses your mind that this may be a significant threat for future PDF or Astra Militarum forces that will have to clean up the rest of the tomb. You may be able to take it out if you play your cards right, but then again, it may just be better to leave well enough alone, and focus on the mission at hand.");
        Console.WriteLine("\nWhat will you do about the Annihilation Barge?\n");
        Console.WriteLine("Options:");
        Console.WriteLine("\"Engage\"");
        Console.WriteLine("\"Avoid\"\n");
        
        string Barge = Console.ReadLine();

        if (Barge == "Avoid")
        {
            Console.WriteLine("\nYou manage to avoid the Annihilation Barge, but make a note of where in the tomb it is for the forces that will sweep through in the future. You are here for the Overlord, and attacking the Barge might just awaken more of the tomb, so perhaps it was for the best.");
            Console.WriteLine("\nYou venture deeper into the tomb, and eventually, after fighting through some more Necron infantry, come across the Overlord's chambers.");
            Console.WriteLine("\nThis is it. This is where you will find the Overlord that you have been sent to assassinate. Killing the Overlord will decapitate this tomb world's forces,\nand make it easier on the Planetary Defense Forces, and Astra Militarum who will be sent to clean up the rest of the Necrons here as they awaken.");
            Console.WriteLine("\nMoving into the chamber, you spot the foul xenos leader, looking significantly more advanced than the infantry you have fought along the way.");
            Console.WriteLine("\nIn a deep and booming voice, the Overlord speaks: \"You disgusting insects desecrate MY tomb world with your very presence! I do not know how you made it here, but it does not matter. I will awaken my dynasty and cleanse this world of pests like you.\"");
            Console.WriteLine("\nThe Overlord moves to attack, but fortunately, you are Astartes, and your incredible reflexes let you act faster than he can. You have only one chance to decide what to do, and it is critical that you make the correct choice.");
            Console.WriteLine("\nOptions:");
            Console.WriteLine("\"Assault\" - You go straight for the Overlord himself. Perhaps if you attack him immediately, you can end the fight quickly, before things escalate.");
            Console.WriteLine("\"Command Console\" - You go for the command console he is standing beside instead. It's not clear what it is for, but it's presumably linked to the tomb world's systems.\n");
            
            string OverlordFlank = Console.ReadLine();

            if (OverlordFlank == "Command Console")
            {
                Console.WriteLine("\nYou and your brothers immediately go for the command console, and to the Overlord's dismay, it explodes in a burst of green energy.");
                Console.WriteLine("\nThe Overlord becomes enraged, saying \"You vile worms. I will not be defeated by the likes of you in my own tomb world! You face Xerathas, the Lord of Storms. Come, I will show you insects what fear truly is.\"");
                Console.WriteLine("\nAfter a long and intense battle with one of the Necrons' best, through the power of the God-Emperor of Mankind, you prevail, and utterly destroy the Lord of Storms.");
                Console.WriteLine("\nThis tomb world's forces have been decapitated, and without their Overlord, will be easy pickings for the other forces sent to clean the rest up.");
                Console.WriteLine("\nYou face little resistance leaving the tomb, and manage to reach the surface. You radio in to Master Lazarus, and inform him that the job is done.");
                Console.WriteLine("He says, \"Excellent work, Brothers. The Lion would be proud of your accomplishments here. You have done a great deed this day, and the tale of your success will go down in chapter history.\nI will send a Thunderhawk planetside to bring you back to the Battle Barge. Lazarus out.\"");
                Console.WriteLine("\n\nMission Accomplished.");
            }

            else if (OverlordFlank == "Assault")
            {
                Console.WriteLine("\nYou decide to attack the Overlord directly. The Overlord says to you, \"It has been a long time since I have indulged in the thrill of combat. I will take great pleasure in rending the flesh from your bones.\"");
                Console.WriteLine("\nThe Overlord blocks your shots with an energy field, and then reaches over to the command console, and taps several buttons. Moments later, hundreds of robotic scarab beetles, called Canoptek Scarabs, begin pouring out of the walls. Moments after that, a dozen Necron Warriors, and even some of the Overlord's bodyguards, the Lychguard, have appeared, with even more still waking up.");
                Console.WriteLine("\n\"Ahahaha! I will first awaken my tomb world, and then I will set out to awaken the rest of the Necrontyr so that we may cleanse your repulsive species from OUR galaxy!\"");
                Console.WriteLine("\nSoon, there are far too many Necrons for your squad to handle on top of the Overlord. Victory seems unachievable now, and it may take destroying the entire planet to prevent this tomb from awakening at this point.");
                Console.WriteLine("\nYour mission has failed. With the Overlord beginning to awaken his tomb world, you are forced to retreat, and have unintentionally emboldened the enemy. You fight tirelessly, cutting down Necron after Necron, and bruised and bloodied, your squad eventually reaches the surface. Back on the surface, while still fighting some of the Necrons that have been tailing you, you radio in to the Battle Barge, and request a Thunderhawk extraction.");
                Console.WriteLine("\n\nReturning to the Battle Barge, you speak with Master Lazarus for debriefing. Calmly, but with the smallest hint of frustration leaking through, he says \"What exactly happened down there?\"");
                Console.WriteLine("\nYou reply that you were unable to defeat the Overlord, and that he began to awaken the tomb before you could take him out.");
                Console.WriteLine("\n\"I am not pleased. Grand Master Azrael will have to hear about this, and we may have to order an exterminatus before things get out of hand. We will discuss possible penance later on. You are dismissed.\"");
                Console.WriteLine("\n\nMission Failed.");
            }
        }

        else if (Barge == "Engage")
        {
            Console.WriteLine("\nYou decide to engage the Annihilation Barge. Your squad is equipped with Krak Grenades, which are perfect for anti-tank purposes, so taking out the tank is really just a matter of getting in throwing range.");
            Console.WriteLine("\nUnfortunately, your squad is quite far away from the Barge, and will need to move up a fair distance to actually get within range. The Barge hasn't spotted you yet, so hopefully you can get within range before it does.");
            Console.WriteLine("\nYou and your squad break into a full sprint, dodging in and out of cover to stay out of the patrolling Barge's sight. Before you can even react, the Barge spots one of your brothers, and fires its main cannon directly at him.");
            Console.WriteLine("\nHe isn't in cover when it fires, and is practically vaporised by the direct hit from the Barge's twin-linked Tesla Destructors. There are still two of you up though, and you will *not* let your brother's sacrifice go in vain. The two of you continue your charge at the now-alert Necron tank, narrowly avoiding being hit by its blasts.");
            Console.WriteLine("\nSuddenly, your other battle brother is hit by the Barge's Tesla Destructors. He's not instantly vaporized, but he's badly wounded, and falls to the floor, unable to continue charging. Your conviction is only stronger now. You utter a prayer to the God-Emperor as you let loose the Krak Grenade towards the Barge. You wonder if the Emperor must have answered your prayer, because the Krak Grenade lands directly on the Barge's central power core.");
            Console.WriteLine("\nYou don't have much time to wonder, however, because moments later, before the grenade detonates, you are struck by a direct hit from the Barge's Tesla Destructor. Half of your body is blown clean off, but in your last moments, you witness the Annihilation Barge explode in a brilliant flash of neon green energy.");
            Console.WriteLine("\nYour last words are \"Praise..the..Emperor...\", as the life drains from your body, and you go forth to meet Him.");
            Console.WriteLine("\nUp above the planet, in the Dark Angels Battle Barge, Master Lazarus speaks to Ezekiel, his Lieutenant; \"Lieutenant, Squad 6 has been lost. I have a report that they were killed by a Necron Annihilation Barge down in the tomb, but managed to take it out before falling. We still need to deal with the Overlord before we can send in the PDF and the Guard. I need you to head in with two squads to finish the job before the Overlord begins awakening the rest of the tomb world. Make sure to bring an Eradicator Squad in case more of their vehicles are active.\" Ezekiel replies, \"Very well. We will avenge our fallen brothers, and destroy the xenos Overlord.\"");
            Console.WriteLine("\n\nMission Failed.");
        }
    }

    else if (TacticsFlank == "Bolt Rifles")
    {
        Console.WriteLine("\nYou open up with your Bolt Rifles, and start picking off the Necron Warriors one by one. Unfortunately, the Bolt Rifles don't penetrate the Necrons' necrodermis quite as well, and it's taking way too long to take out this group of Warriors. By the time you've cleared out the squad of Necron Warriors, more are starting to show up.");
        Console.WriteLine("\nWith all of the commotion, and all of the Necrons that are attracted to your position, it's becoming clear to you that the tomb is just beginning to awaken. The more Necrons you take out, the more keep coming, and soon enough, it's starting to become unmanageable, even for veteran Astartes.");
        Console.WriteLine("\nA short while later, amidst all of the fighting, elite Necron units start showing up, like the terrifying Skorpekh Destroyers, or the robotically precise Deathmark Sniper. You take this as a queue to order a retreat, as these units are far too numerous and far too deadly for a squad of three to deal with.");
        Console.WriteLine("\nHeading out as fast as you can, you and your squad carve a path back to the surface, fighting tirelessly the entire way. You are briefly detected by the Annihilation Barge you avoided earlier, but you manage to evade it, and make it all the way back to the surface, albeit bloodied and bruised from all of the intense combat.");
        Console.WriteLine("\nOn the surface, amidst fighting the Necrons that have been following you up, you radio in to the Dark Angels Battle Barge, and manage to request a Thunderhawk extraction. The Thunderhawk arrives, and you and your squad board the ship under cover of Lascannon and Heavy Bolter fire.");
        Console.WriteLine("\n\nAboard the Battle Barge, you meet with Master Lazarus to explain to him what's just happened.");
        Console.WriteLine("\nYou explain to him that you went into the tomb, but that your Bolt Rifles were insufficient to quickly deal with the Necrons. With how long it took to take them out, you ended up creating enough commotion to wake at least part of the tomb.");
        Console.WriteLine($"\n\"I see. I am not exactly pleased about this outcome, but I suppose it at least provides us some insight as to how we can adapt to fighting the Necrons. That said, I would expect you to adapt to the situation, Sergeant {Name}, and not continue using a tactic that is ineffective until things get that bad. This tomb awakening may force us to resort to exterminatus to save this start system, and if that happens, I will have to report to Grand Master Azrael exactly what happened here. We will discuss this further in detail, as well as whether or not penance is in order, at a later date. I have matters to attend to at the moment. Dismissed, Squad 6.\"");
        Console.WriteLine("\n\nMission Failed.");
    }
}

//If they decide to take them on head on, then it branches off to this bit where they'll have to decide between grenades or power swords.
else if (Approach == "Head On")
{
    Console.WriteLine("\nYou decide to take the head on approach, and engage the necrons immediately. Necrons are tough foes with regenerative abilities and plenty of firepower, but you've got some options on how to deal with them.\n\nWhich weapons will you use to defeat this squad of Warriors?");
    Console.WriteLine("\nOptions:");
    Console.WriteLine("\"Power Swords\" - Use your master-crafted Power Swords to bring the fight to the Necrons up close.");
    Console.WriteLine("\"Krak Grenades\" - Throw armor-piercing sticky grenades at the Necron Warriors, hopefully catching multiple in the blast.\n");
    
    string TacticsHeadOn = Console.ReadLine();

    if (TacticsHeadOn == "Power Swords")
    {
        Console.WriteLine("\nYou decided to use your  Power Swords to cut down the Warriors. It was quite effective, and the Warriors now lie disabled on the ground, with the rest of the tomb none the wiser.");
        Console.WriteLine("\nUnfortunately, during the fight, you seem to have caught the attention of a Necron Deathmark; A deadly foe that uses an armor-piercing sniper rifle to disintegrate foes from long-range.");
        Console.WriteLine("\nYou are going to have to do something, as you can't just remain in the open with this xenos sniper taking aim at your squad. What will you do?");
        Console.WriteLine("\nOptions:");
        Console.WriteLine("\"Attack\" - You turn to face the Deathmark, and begin moving to assault its position. You can't allow such a dangerous foe to freely take aim at your brothers.");
        Console.WriteLine("\"Avoid\" - You decide to pull back, and avoid the Deathmark entirely. This is a dangerous foe, and we are here to slay an Overlord. Taking risks like that is unnecessary.\n");
        
        string Deathmark = Console.ReadLine();

        if (Deathmark == "Avoid")
        {
            Console.WriteLine("\nYou manage to avoid the Deathmark, and lose it in the vast Necron tomb. There are more pressing matters than taking out a lone sniper.");
            Console.WriteLine("\nYou venture deeper into the tomb, and eventually, after fighting through some more Necron infantry, come across the Overlord's chambers.");
            Console.WriteLine("\nThis is it. This is where you will find the Overlord that you have been sent to assassinate. Killing the Overlord will decapitate this tomb world's forces,\nand make it easier on the Planetary Defense Forces, and Astra Militarum who will be sent to clean up the rest of the Necrons here as they awaken.");
            Console.WriteLine("\nMoving into the chamber, you spot the foul xenos leader, looking significantly more advanced than the infantry you have fought along the way.");
            Console.WriteLine("\nIn a deep and booming voice, the Overlord speaks: \"You disgusting insects desecrate MY tomb world with your very presence! I do not know how you made it here, but it does not matter. I will awaken my dynasty and cleanse this world of pests like you.\"");
            Console.WriteLine("\nThe Overlord moves to attack, but fortunately, you are Astartes, and your incredible reflexes let you act faster than he can. You have only one chance to decide what to do, and it is critical that you make the correct choice.");
            Console.WriteLine("\nOptions:");
            Console.WriteLine("\"Assault\" - You go straight for the Overlord himself. Perhaps if you attack him immediately, you can end the fight quickly, before things escalate.");
            Console.WriteLine("\"Command Console\" - You go for the command console he is standing beside instead. It's not clear what it is for, but it's presumably linked to the tomb world's systems.\n");
            
            string OverlordHeadOn = Console.ReadLine();

            if (OverlordHeadOn == "Command Console")
            {
                Console.WriteLine("\nYou and your brothers immediately go for the command console, and to the Overlord's dismay, it explodes in a burst of green energy.");
                Console.WriteLine("\nThe Overlord becomes enraged, saying \"You vile worms. I will not be defeated by the likes of you in my own tomb world! You face Xerathas, the Lord of Storms. Come, I will show you insects what fear truly is.\"");
                Console.WriteLine("\nAfter a long and intense battle with one of the Necrons' best, through the power of the God-Emperor of Mankind, you prevail, and utterly destroy the Lord of Storms.");
                Console.WriteLine("\nThis tomb world's forces have been decapitated, and without their Overlord, will be easy pickings for the other forces sent to clean the rest up.");
                Console.WriteLine("\nYou face little resistance leaving the tomb, and manage to reach the surface. You radio in to Master Lazarus, and inform him that the job is done.");
                Console.WriteLine("He says, \"Excellent work, Brothers. The Lion would be proud of your accomplishments here. You have done a great deed this day, and the tale of your success will go down in chapter history.\nI will send a Thunderhawk planetside to bring you back to the Battle Barge. Lazarus out.\"");
                Console.WriteLine("\n\nMission Accomplished.");
            }

            else if (OverlordHeadOn == "Assault")
            {
                Console.WriteLine("\nYou decide to attack the Overlord directly. The Overlord says to you, \"It has been a long time since I have indulged in the thrill of combat. I will take great pleasure in rending the flesh from your bones.\"");
                Console.WriteLine("\nThe Overlord blocks your shots with an energy field, and then reaches over to the command console, and taps several buttons. Moments later, hundreds of robotic scarab beetles, called Canoptek Scarabs, begin pouring out of the walls. Moments after that, a dozen Necron Warriors, and even some of the Overlord's bodyguards, the Lychguard, have appeared, with even more still waking up.");
                Console.WriteLine("\n\"Ahahaha! I will first awaken my tomb world, and then I will set out to awaken the rest of the Necrontyr so that we may cleanse your repulsive species from OUR galaxy!\"");
                Console.WriteLine("\nSoon, there are far too many Necrons for your squad to handle on top of the Overlord. Victory seems unachievable now, and it may take destroying the entire planet to prevent this tomb from awakening at this point.");
                Console.WriteLine("\nYour mission has failed. With the Overlord beginning to awaken his tomb world, you are forced to retreat, and have unintentionally emboldened the enemy. You fight tirelessly, cutting down Necron after Necron, and bruised and bloodied, your squad eventually reaches the surface. Back on the surface, while still fighting some of the Necrons that have been tailing you, you radio in to the Battle Barge, and request a Thunderhawk extraction.");
                Console.WriteLine("\n\nReturning to the Battle Barge, you speak with Master Lazarus for debriefing. Calmly, but with the smallest hint of frustration leaking through, he says \"What exactly happened down there?\"");
                Console.WriteLine("\nYou reply that you were unable to defeat the Overlord, and that he began to awaken the tomb before you could take him out.");
                Console.WriteLine("\n\"I am not pleased. Grand Master Azrael will have to hear about this, and we may have to order an exterminatus before things get out of hand. We will discuss possible penance later on. You are dismissed.\"");
                Console.WriteLine("\n\nMission Failed.");
            }
        }

        else if (Deathmark == "Attack")
        {
            Console.WriteLine("\nYou decide to attack the Deathmark directly. You and your brothers charge the Deathmark, narrowly dodging the sniper's lethal shots.");
            Console.WriteLine("\nHalfway to the Deathmark's location, it disappears. Moments later, one of your brothers falls to the ground, his power armor glowing in one area with a neon green corruption.");
            Console.WriteLine("\nDeathmarks are able to teleport short distances to change firing position. This is a difficult situation. A few moments later, your other battle brother falls as well, the same energy visible on a different part of his armor.");
            Console.WriteLine("\nYour squadmates are down, but you're still in the fight, and you are no aspirant. You charge the Deathmark's new position, dipping in and out of cover to avoid its fire.");
            Console.WriteLine("\nJust as you think you've got it, it disappears, and you are struck in the back before you can react, even with your superhuman reflexes.");
            Console.WriteLine("\n\nThe Necron Deathmark has defeated you, despite your best efforts. Pain courses throughout your body, and your flesh begins to disintegrate within your armor. You pray to the God-Emperor in your last moments, but he does not grant you a miracle, if he even hears you at all.");
            Console.WriteLine("\nUp above the planet, in the Dark Angels Battle Barge, Master Lazarus speaks to Ezekiel, his Lieutenant; \"Lieutenant, Squad 6 has been lost. We still need to deal with the Overlord before we can send in the PDF and the Guard. I need you to head in with two squads to finish the job before the Overlord begins awakening the rest of the tomb world.\" Ezekiel replies, \"Very well. We will avenge our fallen brothers, and destroy the xenos Overlord.\"");
            Console.WriteLine("\n\nMission Failed.");
        }
    }

    else if (TacticsHeadOn == "Krak Grenades")
    {
        Console.WriteLine("\nYou opt to throw the Krak Grenades at the Warriors. You and your brothers each prepare a grenade, pull the pin, and throw the grenades at the Necrons, each grenade sticking to a different Warrior.");
        Console.WriteLine("\nUnfortunately, it is immediately apparent that this was not particularly effective. Krak Grenades are primarly for anti-tank purposes, and don't work as well against infantry. They were the only explosives your squad brought, however, so it did not seem like a bad idea to use for crowd control.");
        Console.WriteLine("\nThe Krak Grenades take out a few Warriors, but there are too many for the grenades to be effective. Moments later, you notice more Necrons beginning to wake up. It seems as though the Tomb World detected your explosives, and is beginning to wake up so as to deal with the threat you pose.");
        Console.WriteLine("\nYou fight the Necrons that are awakening with blade and bolter, but after a short while, you begin to get overwhelmed by the volume of fire from the Necrons' gauss weapons.");
        Console.WriteLine("\nAs you are getting overwhelmed, you order your unit to retreat, and fight your way out of the tomb, carving a path back to the surface.");
        Console.WriteLine("\n\nBack on the surface, you radio in to a very unimpressed Master Lazarus who tersely informs you that he's sending a Thunderhawk to extract your squad.");
        Console.WriteLine("A while later, back on the Battle Barge, you speak with Master Lazarus and explain what happened in detail.");
        Console.WriteLine($"\n\"I see. I am not impressed, Sergeant {Name}. I would expect such decisions from aspirants, but not from a veteran Sergeant such as yourself. Your objective was to infiltrate the tomb and eliminate the Overlord without awakening the tomb world, but you have unwittingly begun the awakening process, and now this entire conflict will have to be escalated. I have things to attend to at the moment, but we will speak later of penance for such mistakes. Dismissed.\"");
        Console.WriteLine("\n\nMission Failed.");
    }
}

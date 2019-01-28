using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneDialogues{

    public Dialogue[] scene0;
    public Dialogue[] scene1;
    public Dialogue[] scene2;
    public Dialogue[] scene3;
    public Dialogue[] scene4;
    public Dialogue[] scene5;
    public Dialogue[] scene6;
    public Dialogue[] scene7;
    public Dialogue[] scene8;


    private Color systemColor;
    private Color collinsColor;
    private Color jenkinsColor;
    private Color millerColor;

    private Color reportColor;
    private Color whiteColor;
    private Color smithColor;
    private Color crassColor;

    public SceneDialogues()
    {
        systemColor = new Color(57f / 255f, 140f / 255f, 53f / 255f, 1f);
        jenkinsColor = new Color(66f / 255f, 244f / 255f, 134f / 255f, 1f);
        collinsColor = new Color(66f / 255f, 220f / 255f, 244f / 255f, 1f);
        millerColor = new Color(188f / 255f, 41f / 255f, 85f / 255f, 1f);

        reportColor = new Color(1f, 1f, 1f, 1f);
        whiteColor = new Color(.8f, .8f, .8f, 1f);
        smithColor = new Color(188f / 255f, 100f / 255f, 41f / 255f, 1f);
        crassColor = new Color(9f / 255f, 90 / 255f, 165f / 255f, 1f);

        scene0 = new Dialogue[17];
        scene0[0] = new Dialogue("system", systemColor, new string[] 
            { "[Boot Success!]", "Welcome to the Automated Criminal Analysis Portal."});
        scene0[1] = new Dialogue("Collins", collinsColor, new string[] 
            { "Whew, Spooky.", "Not nearly as impressive as that techie said it was though.",
            "This little guy's supposed to do our job isn't it?" });
        scene0[2] = new Dialogue("Jenkins", jenkinsColor, new string[] 
            { "That's no way to talk to your future boss, Collins."});
        scene0[3] = new Dialogue("Collins", collinsColor, new string[]
            { "Har, Har."});
        scene0[4] = new Dialogue("Miller", millerColor, new string[]
            { "Relax, Collins, you still have a couple of years left.",
               "Central's just sending it in from testing.",
               "They need someone to do data processing, you know, show it the ropes."});
        scene0[5] = new Dialogue("Jenkins", jenkinsColor, new string[]
            { "I think I'll pass on that one.", "Not too excited to check over Central's homework." });
        scene0[6] = new Dialogue("Collins", collinsColor, new string[]
            { "I'm on leave next week. Sorry Miller, you're on your own."});
        scene0[7] = new Dialogue("Miller", millerColor, new string[]
            { "Thanks for the help, guys."});
        scene0[8] = new Dialogue("system", systemColor, new string[]
            { "Please input case data." });
        scene0[9] = new Dialogue("Miller", millerColor, new string[]
            { "Well? Got anything for our newest detective?"});
        scene0[10] = new Dialogue("Jenkins", jenkinsColor, new string[]
    {       "Start it off with something simple.", "The case from last week should work."});
        scene0[11] = new Dialogue("system", systemColor, new string[]
            { "Processing case data." }); //transition into case screen.
        scene0[12] = new Dialogue("Miller", millerColor, new string[]
            { "Alright then. Show us what you got, Sherlock."});
        scene0[13] = new Dialogue("Collins", collinsColor, new string[]
            { "Sherlock?"});
        scene0[14] = new Dialogue("Miller", millerColor, new string[]
            { "Yeah, Watson's already taken."});
        scene0[15] = new Dialogue("system", systemColor, new string[]
            { "- H-9303 police report added to Inventory" }); //spawn case folder 0
        scene0[16] = new Dialogue("Miller", millerColor, new string[]
            { "Go on then, work your magic."});
        scene1 = new Dialogue[10];
        scene1[0] = new Dialogue("Brief", reportColor, new string[]
    { "The victim is Haley O'Neil.", "She was found dead outside of the apartment she shared with her fiance of 4 months."});
        scene1[1] = new Dialogue("system", systemColor, new string[]
            { "- Profile of Haley O'Neil added to Inventory"});
        scene1[2] = new Dialogue("Brief", reportColor, new string[]
            { "Her fiance, Drew White, is a primary suspect.",
            "The two of them entered the complex at 2100, as caught by the security camera installed at the front entrance of the complex"});
        scene1[3] = new Dialogue("system", systemColor, new string[]
            { "- Security Camera footage added to Inventory"});
        scene1[4] = new Dialogue("Brief", reportColor, new string[]
            { "The couple then had an altercation, as confirmed by White and one other observer.",
              "Derrick Smith, the next door neighbor, claimed to hear raised voices coming from the victim's apartment"});
        scene1[5] = new Dialogue("system", systemColor, new string[]
            { "- Smith's Statement added to Inventory" });
        scene1[6] = new Dialogue("Brief", reportColor, new string[]
            { "This story was corroborated by the victim's fiance, who admitted to having argued with the victim that evening"});
        scene1[7] = new Dialogue("system", systemColor, new string[]
            { "- White's Statment added to Inventory"});
        scene1[8] = new Dialogue("Brief", reportColor, new string[]
            { "White was on camera leaving the apartment at 22:30.",
              "The body was then discovered at the foot of the victim's balcony.",
              "Emergency Responders were called at 23:00 and arrived at 23:15. At that point, the " +
              "victim was confirmed by paramedics to be deceased.",
              "Well there you have it. You should have all the evidence you need to bring this guy in."});
        scene1[9] = new Dialogue("system", systemColor, new string[]
            { "- Click on items in your inventory to replay statements and examine evidence. When you find an inconsistency, " +
              "challenge it by pressing this \"Challenge\", and provide the evidence which contradicts the statement."});
        scene2 = new Dialogue[2];
        scene2[0] = new Dialogue("White", whiteColor, new string[] 
        {
            "I was coming home with Haley after dinner. It must have been 9:00 at night",
            "I... I feel so stupid.",
            "I started yelling at her because she lost our engagement ring",
            "That ring... I bought it four months ago, and she never took it off.",
            "I don't believe that she'd lose it.",
            "After we fought, I walked downstairs to get some fresh air.",
            "You picked me up as soon as I got back",
            "I swear, I'd never hurt her"
        });
        scene2[1] = new Dialogue("system", systemColor, new string[]
        {
            "END OF STATEMENT"
        });
        scene3 = new Dialogue[2];
        scene3[0] = new Dialogue("Smith", smithColor, new string[]
        {
            "Yeah I heard them last night, alright.",
            "I'm an insomniac, so I'm always in and out of sleep at this hour. When I'm even slightly awake, you'd better " +
             "believe I hear everything that goes on in there.",
            "These walls are thin as sin, I tell you what.",
            "Anyways, I hear the lady screaming her head off at 10:30 at night",
            "The man in there was quieter, but you could still tell he was furious.",
            "If I knew what was gonna happen, I'd go in there and teach them a lesson myself.",
            "I had already taken my pills though, so I tried to close my eyes again.",
            "They must have been at it for at least 15 minutes."
        });
        scene3[1] = new Dialogue("system", systemColor, new string[]
        {
            "END OF STATEMENT"
        });
        scene4 = new Dialogue[2];
        scene4[0] = new Dialogue("Crass", crassColor, new string[]
        {
            "I walk around the neighborhood all the time. Gotta keep those joints loose after all.",
            "I'm walking like normal when I see that girl sat out on the balcony.",
            "She's leaning over looking at me, so I go to wave.",
            "All of a sudden, she falls head-first over the railing",
            "I was worried she might have caught the bad side of a concussion, so I called you.",
            "That bastard must have clocked her and left her out there to dry"
        });
        scene4[1] = new Dialogue("system", systemColor, new string[]
        {
            "END OF STATEMENT"
        });

        scene5 = new Dialogue[2];
        scene5[0] = new Dialogue("Brief", reportColor, new string[]
        {
            "Name: Haley O'Neil\nAge:24",
            "Estimated Time of Death: 1995-09-24 22:30",
            "Cause of Death: Blunt Force Trauma",
            "Discovered underneath the balcony of her 3rd floor apartment"
        });
        scene5[1] = new Dialogue("System", systemColor, new string[]
        {
            "END OF STATEMENT"
        });

        scene6 = new Dialogue[2];
        scene6[0] = new Dialogue("System", reportColor, new string[]
        {
            "CCTV Recording Data: 09-24",
            "2000: Mr. Smith enters through front entrance",
            "2100: Mr. White and Ms. O'Neil enter through front entrance",
            "2230: Mr. White exits through front entrance"
        });
        scene6[1] = new Dialogue("System", systemColor, new string[]
        {
            "END OF STATEMENT"
        });

        scene7 = new Dialogue[5];
        scene7[0] = new Dialogue("Jenkins", jenkinsColor, new string[]
        {
            "I'd rather you not exaggerate. O'Neil and White couldn't have been arguing at 10:30, because White had already " +
            "left the building.",
            "There was only one person in the apartment: Ms. O'Neil."
        });
        scene7[1] = new Dialogue("Smith", smithColor, new string[]
        {
            "I'd rather you not call me a liar. I know what I heard."
        });
        scene7[2] = new Dialogue("Miller", millerColor, new string[]
        {
            "Hey, maybe he's telling the truth. Give me the file, we'll look over it more closely."
        });
        scene7[3] = new Dialogue("Jenkins", jenkinsColor, new string[]
        {
            "Don't be ridiculous, there's a perfectly reasonable explanation for what's going on."
        });
        scene7[4] = new Dialogue("System", systemColor, new string[]
        {
            "- Jenkins's Explanation added to Inventory"
        });

        scene8 = new Dialogue[2];
        scene8[0] = new Dialogue("Jenkins", jenkinsColor, new string[]
        {
            "Look, that old guy's probably just got a bad memory.",
            "White already said that he was arguing with the victim, right?",
            "He probably attacked her during that argument, at 21:30.",
            "Smith probably heard them then.",
            "White then hid the body in the apartment and left at 22:30 to find somewhere to get rid of her.",
            "We're just lucky we got to the apartment before he could get away with it."
        });
        scene8[1] = new Dialogue("System", systemColor, new string[]
        {
            "END OF STATEMENT"
        });

    }
}

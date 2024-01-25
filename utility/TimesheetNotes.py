import random

def generateNote(breakfastTime = 9):

    opening = f"""Our goals are to engage verbally with Lily. I arrived and Lily and I got warmed up with light conversation and background noise through the TV. She is often not very interactive in the morning."""
    
    morning = f"""{breakfastTime + 1} AM I supervised her breakfast. After breakfast around {breakfastTime + 1}:30 or {breakfastTime + 2}AM I had Lily speak with {random.choice(["my girlfriend", "her aunt Sharo", "her uncle Brian", "cousin Matt", "cousin Brian", "cousin Alex"])} through video call."""
    
    midday = f"""We talked about {random.choice(["fruit", "food", "desserts", "iCarly", "Paw Patrol"])}. Then at 11AM we went for a walk to the church nearby and back. When we got back, Lily and I {random.choice(["practiced yoga", "played patty cake", "learned a new handshake"])}, talked about fruit, desserts, and her favorite TV shows. 12 to 1PM I supervised her lunch. We watched several episodes of {random.choice(["iCarly", "Paw Patrol", "Sam and Cat", "Pokemon"])} and we talked about her favorite characters."""
    
    afternoon = f"""Around 3PM we talked more and I continued teaching her a secret handshake."""

    evening = f"""At 4:30PM we watched the {random.choice(["iCarly", "Avengers", "Pokemon"])} movie together and talked about her favorite character. I then supervised her dinner. Around 6PM I had Lily call her aunt to talk."""
    
    leavingTime = f"""Then I got prepared to leave and Lily and I did our handshake and I made her remember the next time I will come."""


    out = "" 
    out += opening # no specific time -- mentions morning
    out += morning # set breakfast time, <= 9AM 
    out += midday  # starts at 11AM
    out += afternoon # starts 3PM
    out += evening # starts 4:30PM to 6PM
    out += leavingTime # any time

    print(out)


generateNote(11)
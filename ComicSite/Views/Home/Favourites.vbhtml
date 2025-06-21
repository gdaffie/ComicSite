@Code
    ViewData("Title") = "Favourites"
End Code
<style>
    h2, p, a, div {
        text-align: center;
    }
</style>

<h2>@ViewData("Title")</h2>


<div class="card-columns">

    <div class="col-md-4">
        <style>
            img {
                vertical-align: middle;
                margin-left: auto;
                margin-right: auto;
                width: 280px;
                height: 280px;
            }

            .cards {
                margin: 0 auto;
                height:900px;
                width:1200px;
                display: grid;
                grid-template-columns: repeat(auto-fill, minmax(225px, 1fr));
                grid-auto-rows: auto;
                gap: 20px;
                font-family: sans-serif;
                padding-top: 30px;
            }

            .cards * {
                box-sizing: border-box;
            }

            .card__image {
                width: 100%;
                height: 150px;
                object-fit: cover;
                display: block;
                border-top: 2px solid #333333;
                border-right: 2px solid #333333;
                border-left: 2px solid #333333;
            }

            .card__content {
                line-height: 1.5;
                font-size: 0.9em;
                padding: 15px;
                background: #fafafa;
                border-right: 2px solid #333333;
                border-left: 2px solid #333333;
            }

            .card__content > p:first-of-type {
                margin-top: 0;
            }

            .card__content > p:last-of-type {
                margin-bottom: 0;
            }

            .card__info {
                padding: 15px;
                display: flex;
                justify-content: space-between;
                align-items: center;
                color: #555555;
                background: #eeeeee;
                font-size: 0.8em;
                border-bottom: 2px solid #333333;
                border-right: 2px solid #333333;
                border-left: 2px solid #333333;
            }

            .card__info i {
                font-size: 0.9em;
                margin-right: 8px;
            }

            .card__link {
                color: #64968c;
                text-decoration: none;
            }

           .card__link:hover {
                text-decoration: underline;
           }
        </style>


<link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
<div class="cards">
    <div class="card">
        <img class="card__image" src="~/img/watchmen.jpg" alt="">
        <div class="card__content">
            <p>
                <h2>Watchmen Paperback</h2>
            </p>
            <p>
                A murder mystery-turned-nationwide conspiracy, Watchmen examines the lives of the eponymous superhero team as they seem to decay alongside the ever-darkening America around them.
                Rorschach, Nite Owl, the Silk Spectre, Dr. Manhattan and Ozymandias reunite to investigate who’s behind a teammate’s murder, but find that the truth may be even more grim than the world
                they seek to protect.
            </p>
        </div>
        <div class="card__info">
            <div>
                <i class="material-icons">thumb_up</i> 9,363
            </div>
            <div>
                <a href="https://www.amazon.com/gp/product/1401245250/ref=as_li_tl?ie=UTF8&camp=1789&creative=390957&creativeASIN=1401245250&linkId=ROIE4NZUNP3WLMFN" class="card__link">View Amazon Page</a>
            </div>
        </div>
    </div>
    <div class="card">
        <img class="card__image" src="~/img/MIND-MGMT-v1.jpg" alt="">
        <div class="card__content">
            <p>
                <h2>MIND MGMT Volume 1</h2>
            </p>
            <p>
                Matt Kindt, the most original voice in genre comics, outdoes himself in this bold new espionage series! Reporting on a commercial flight where everyone aboard lost their memories,
                a young journalist stumbles onto a much bigger story - the top-secret Mind Management program. Her ensuing journey involves weaponized psychics, hypnotic advertising, talking dolphins,
                and seemingly immortal pursuers, as she attempts to find the flight's missing passenger, the man who was MIND MGMT's greatest success - and its most devastating failure.
                But in a world where people can rewrite reality itself, can she trust anything she sees?
            </p>
        </div>
        <div class="card__info">
            <div>
                <i class="material-icons">thumb_up</i> 94
            </div>
            <div>
                <a href="https://www.amazon.com/gp/product/1595827978/ref=as_li_tl?ie=UTF8&camp=1789&creative=390957&creativeASIN=1595827978&linkId=FAYRWLTOHMT42BKE" class="card__link">View Amazon Page</a>
            </div>
        </div>
    </div>
    <div class="card">
        <img class="card__image" src="~/img/lastman.jpg" alt="">
        <div class="card__content">
            <p>
                <h2>The Last Man, Book 1</h2>
            </p>
            <p>
                "The first ten issues of the award-winning series written by Brian K. Vaughan (EX MACHINA, Lost) are collected in an oversized hardcover with a new cover!
                Don't miss the amazing SF epic that Stephen King called "The best graphic novel I've ever read."
            </p>
        </div>
        <div class="card__info">
            <div>
                <i class="material-icons">thumb_up</i> 1,613
            </div>
            <div>
                <a href="https://www.amazon.com/gp/product/1401219217/ref=as_li_tl?ie=UTF8&camp=1789&creative=390957&creativeASIN=1401219217&linkId=5O4OAFZTNPKTTTO7" class="card__link">View Amazon Page</a>
            </div>
        </div>
    </div>
    <div class="card">
        <img class="card__image" src="~/img/buildingstories.jpg" alt="">
        <div class="card__content">
            <p>
                <h2>Building Stories</h2>
            </p>
            <p>
                With the increasing electronic incorporeality of existence, sometimes it’s reassuring—perhaps even necessary—to have something to hold on to.
                Thus within this colorful keepsake box the purchaser will find a fully-apportioned variety of reading material ready to address virtually any imaginable artistic or poetic taste,
                from the corrosive sarcasm of youth to the sickening earnestness of maturity—while discovering a protagonist wondering if she’ll ever move from the rented close quarters of lonely
                young adulthood to the mortgaged expanse of love and marriage. Whether you’re feeling alone by yourself or alone with someone else,
                this book is sure to sympathize with the crushing sense of life wasted, opportunities missed and creative dreams dashed which afflict the middle- and upper-class literary public
                (and which can return to them in somewhat damaged form during REM sleep).
            </p>
        </div>
        <div class="card__info">
            <div>
                <i class="material-icons">thumb_up</i> 558
            </div>
            <div>
                <a href="https://www.amazon.com/Building-Stories-Pantheon-Graphic-Library/dp/0375424334/ref=sr_1_1?keywords=building+stories+by+chris+ware&sr=8-1" class="card__link">View Amazon Page</a>
            </div>
        </div>
        <br />
    </div>
</div>

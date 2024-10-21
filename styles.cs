@charset "UTF-8";
/* Setjum inn „reset“ sem fjarlægir margin og padding af öllu */
* {
  margin: 0;
  padding: 0;
}

/* Reiknum stærð á öllum boxum sem border-box */
html {
  box-sizing: border-box;
}

/* og látum erfast á allt */
*,
*:before,
*:after {
  box-sizing: inherit;
}

/* hjálpar class sem felur sjónrænt en skjálesarar lesa */
.sr-only:not(:focus):not(:active) {
  clip: rect(0 0 0 0);
  clip-path: inset(50%);
  height: 1px;
  overflow: hidden;
  position: absolute;
  white-space: nowrap;
  width: 1px;
}

:root {
  --font-size-base: 16px;
  --font-size-headings: 1.5rem;
  /* Grunn bilið okkar er 1rem == 16px */
  --spacing: 1rem;
  /* Bil á milli „stærri“ eininga (header, efnisbox, footer) */
  --vertical-space: calc(var(--gutter) * 1);
  --vertical-space-large: calc(var(--gutter) * 1.5);
  /* Hámarks og lágmarks breidd á efni */
  --max-width: 1200px;
  --min-width-image: 200px;
  --max-width-image: 300px;
  --max-width-footer-section: 250px;
  --font-family-poppins: "Poppins", sans-serif;
  --font-family-poppins-bold: "Poppins-Bold", sans-serif;
  --font-family-playfair: "Playfair Display", serif;
  /* Grid stillingar */
  --columns: 12;
  --gutter: 30px;
  --offset: 20px;
  /* Breidd á efni með offset */
  --width-offset: calc(100% - (2 * var(--offset)));
  /* Transitions */
  --transition-time-short: 300ms;
  --transition-time-long: 600ms;
  --transition-timing-function: ease-in-out;
  /* Litir */
  --color-beige: #E3CDB1;
  --color-faded-beige: #F7F1EB;
  --color-grey: #F6F6F6;
  --color-dark-grey: #5E5B69;
}

.button {
  display: inline-block;
  text-align: center;
  border: var(--color-beige) 1px solid;
  padding: 0.5rem 4rem;
  transition: background-color var(--transition-time-short) ease, color var(--transition-time-short) ease;
  text-decoration: none;
  color: var(--color-beige);
}

.button:hover {
  background-color: var(--color-beige);
  color: var(--color-grey);
}

.bottom-button {
  padding: 4rem 0;
  text-align: center;
}

/* "reset" sem fjarlægir default margin og padding af öllu */
* {
  margin: 0;
  padding: 0;
}

@media (min-width: 700px) {
  .wrapper {
    display: grid;
    grid-template-rows: auto;
    grid-template-columns: repeat(12, 1fr);
    justify-items: center;
    gap: 30px;
    width: 100%;
    min-height: 100vh;
  }
}
.wrapper > * {
  grid-column: span 12;
}

.card {
  background-color: white;
  margin-top: var(--spacing);
  margin-right: var(--spacing);
  margin-left: var(--spacing);
  max-width: 500px;
}
.card img {
  height: 206px;
  max-width: 100vh;
  object-fit: cover;
  width: 100%;
}
.card .infobox {
  padding: var(--spacing);
}
.card .infobox div {
  display: flex;
  justify-content: space-between;
}

.cards {
  background: linear-gradient(to bottom, white 10%, var(--color-grey) 10%);
}

@font-face {
  font-family: "Poppins";
  font-style: normal;
  font-weight: 300;
  font-display: swap;
  src: url(../fonts/Poppins/Poppins-Light.ttf) format("woff2");
}
@font-face {
  font-family: "Poppins-Bold";
  font-style: bold;
  font-weight: 500;
  font-display: swap;
  src: url(../fonts/Poppins/Poppins-Regular.ttf) format("woff2");
}
@font-face {
  font-family: "Playfair Display";
  font-style: bold;
  font-weight: 700;
  font-display: swap;
  src: url(../fonts/Playfair_Display/PlayfairDisplay-VariableFont_wght.ttf) format("woff2");
}
h1,
h2,
h3 {
  font-family: var(--font-family-playfair);
}

h2 {
  font-size: 18px;
}

.month {
  font-size: 12px;
  color: #9b9b9b;
}

.desktop {
  font-size: 14px;
  color: #e3cdb1;
  text-decoration: none;
}

.phone {
  font-size: 14px;
  color: #e3cdb1;
  text-decoration: none;
}

html,
input,
button,
select,
textarea {
  font-family: var(--font-family-poppins);
}

/**Index**/
@media (max-width: 700px) {
  .phone {
    display: none;
  }
  .intro {
    text-align: center;
  }
}
/*
@media (max-width: 700px) {
  .desktop {
    display: none;
  }
}
*/
.intro {
  background-color: var(--color-grey);
  background-image: url("../myndir/pumpkinPie.png");
  background-size: 650px;
  background-position: 0px -100px;
  height: 500px;
  background-repeat: no-repeat;
  /**
  img {
      object-fit: cover;
      max-width: 100vh;
      width: 100%;

      position: absolute;
      top: 10px;
      left: 50px;
  }
  **/
}
.intro p, .intro a {
  font-family: var(--font-family-poppins-bold);
  text-decoration: none;
  color: var(--color-beige);
}
.intro h1 {
  padding-top: 0.2rem;
  padding-bottom: 1rem;
}
.intro .subtitle {
  padding-top: 5rem;
  font-size: 12px;
}
.intro img {
  display: none;
}

.text {
  display: flex;
  flex-direction: column;
  gap: 20px;
}

.ingredients li {
  display: flex;
  flex-direction: row;
  gap: 1rem;
}

.text-container {
  display: flex;
  flex-direction: column;
  gap: 1rem;
}

.ingredients-box {
  display: flex;
  flex-direction: column;
  gap: 1rem;
}

.title {
  text-align: center;
  background-color: white;
  padding-top: 2rem;
}
.title p {
  color: var(--color-beige);
  font-family: var(--font-family-poppins-bold);
  font-size: 12px;
}
.title .titleflex {
  display: flex;
  justify-content: center;
  gap: 0.3rem;
}
.title .titleflex h2 {
  color: var(--color-dark-grey);
}
.title .titleflex .secondaryTitle {
  color: black;
}

.level {
  display: flex;
  flex-direction: row;
}

header {
  background-color: white;
  z-index: 1000;
  top: 0;
  position: sticky;
}
header nav {
  width: 100%;
}
header nav div {
  display: flex;
  justify-content: space-between;
  align-items: center;
}
header nav img {
  max-width: 90px;
  margin: var(--spacing);
}
header nav .menu {
  display: none;
  flex-direction: column;
  list-style: none;
  background-color: var(--color-grey);
  width: 100%;
  text-align: center;
  height: 100vh;
}
header nav .hamburger {
  border-bottom: 1px solid var(--color-beige);
  padding: var(--spacing);
}
header nav .hamburger a {
  font-size: 60px;
  font-family: var(--font-family-playfair);
  color: black;
  text-decoration: none;
}
header nav .hamburger-icon,
header nav .cross-icon {
  max-height: 13px;
  cursor: pointer;
  opacity: 1;
  visibility: visible;
  position: absolute;
  right: 0px;
  transition: opacity 0.3s ease-in-out, transform 0.3s ease-in-out;
}
header nav .cross-icon {
  opacity: 0; /* Initially hidden */
  visibility: hidden; /* Prevent it from being clickable */
}

/* css kóði fyrir newsletter og footer næ ekki að tengja þetta við scss*/
.newsletter {
  background-color: #000000;
  padding: 20px;
}

.newsletter-card {
  display: flex;
  flex-direction: column;
  align-items: center;
  padding: var(--spacing);
}

.newsletter-card {
  width: 100%;
  padding: var(--spacing);
}

.newsletter-card p {
  color: #E3CDB1;
  font-size: 12px;
  padding-top: 41px;
}

.newsletter-card h2 {
  color: white;
  font-size: 20px;
}

.newsletter-card p h2 {
  padding-top: 42px;
}

.newsletter-content {
  display: flex;
  flex-direction: column;
  width: 100%;
  max-width: 400px;
  margin-bottom: 10px;
}

.newsletter-content-sub {
  display: flex;
  flex-direction: column;
  width: 80%;
  max-width: 400px;
  margin-bottom: 10px;
}

.newsletter-content label {
  color: rgb(255, 255, 255);
  font-family: var(--font-family-poppins);
  font-size: 12px;
  margin-bottom: 5px;
}

.newsletter-content input {
  padding: 10px;
  border: none;
  border-bottom: 1px solid rgb(227, 205, 177);
  border-radius: 0px;
  width: 100%;
  font-family: var(--font-family-poppins);
  background-color: #000000;
  outline: none;
  color: white;
  font-size: 18px;
}

.newsletter-content input:focus {
  border-bottom: 2px solid rgb(227, 205, 177);
}

/* Button */
/* Footer Styling */
footer {
  display: flex;
  flex-direction: column;
  flex-wrap: nowrap;
  justify-content: space-around;
  padding: 20px;
  background-color: #ffffff;
  color: rgb(227, 205, 177);
  text-align: center;
  padding: 1rem;
}

.footer-text1, .footer-text2 {
  flex: 1;
}

.footer-text1 {
  color: #000000;
  margin: 1rem;
}

.footer-text2 {
  color: rgb(208, 208, 208);
  margin: 1rem;
}

.footer-img {
  flex: 1;
  display: flex;
  justify-content: center;
  align-items: center;
  color: rgb(208, 208, 208);
  margin: 1rem;
}

.footer-img img {
  max-width: 30px;
  margin: 0 10px;
}

/* CSS */
.button-27 {
  appearance: none;
  background-color: #000000;
  border: 2px solid #1A1A1A;
  border-radius: 1px;
  border-color: rgb(227, 205, 177);
  box-sizing: border-box;
  color: rgb(227, 205, 177);
  cursor: pointer;
  display: inline-block;
  font-family: var(--font-family-poppins);
  font-size: 16px;
  font-weight: 600;
  line-height: normal;
  margin: 0;
  min-height: 60px;
  min-width: 0;
  max-height: 42px;
  outline: none;
  padding: 16px 24px;
  text-align: center;
  text-decoration: none;
  transition: all 300ms cubic-bezier(0.23, 1, 0.32, 1);
  user-select: none;
  -webkit-user-select: none;
  touch-action: manipulation;
  will-change: transform;
}

.button-27:focus {
  outline: none;
}

.button-27:disabled {
  pointer-events: none;
}

.button-27:hover {
  box-shadow: rgba(0, 0, 0, 0.25) 0 8px 15px;
  transform: translateY(-2px);
}

.button-27:active {
  box-shadow: none;
  transform: translateY(0);
}

.button-27 {
  justify-content: right;
}

.book {
  text-align: center;
  height: 543px;
  background: linear-gradient(to bottom, var(--color-faded-beige) 75%, white 75%);
  padding-left: var(--spacing);
  padding-right: var(--spacing);
}
.book a {
  color: var(--color-beige);
  text-decoration: none;
}
.book p {
  padding-top: 0.5rem;
  padding-bottom: 1rem;
  color: var(--color-dark-grey);
  font-family: var(--font-family-poppins);
}
.book h2 {
  font-size: 32px;
  padding-top: 4rem;
}
.book img {
  padding-top: 3rem;
  height: auto;
  width: 205px;
}

@media (max-width: 700px) {
  .desktop {
    display: none;
  }
}
.intro {
  grid-column: 3/5; /* Spans from column 2 to column 4 */
  display: flex; /* Use flexbox within .intro for its internal layout */
  flex-direction: column;
}

main {
  width: 100%;
}

/*# sourceMappingURL=styles.cs.map */

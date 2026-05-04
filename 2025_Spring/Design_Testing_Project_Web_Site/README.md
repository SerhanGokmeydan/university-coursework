# SOFTWARE ENGINEERING: USER INTERFACE DESIGN AND TESTING PROJECT

**Project Subject:** Retro Games' Reviews (8-bit Themed Website)

## Group Members and Duties

- **Muhammed Bilal Yilmaz - b241202047:** Coding, Giving ideas, Editing videos for website, Preparing Readme file and presentation.
- **Serhan Gokmeydan - b241202003:** Coding, Giving Ideas, Making animations, Preparing Readme file and presentation

## Project Details

The goal of our website is gathering and showing the reviews for retro games. It introduces nostalgic games (Mario, Pac-Man, Tetris, Donkey Kong) with an 8-bit visual theme. Our site was designed from scratch using HTML, CSS, JavaScript. No ready-made templates or programs were used.

## Requirements Part

### Gathering Data Methods

- **Observing the Audience:** The internet usage habits of the target audience playing games were observed.
- **Interviewing and Questionnaires:** Short interviews were conducted with our target audience to determine the design expectations (dark theme, pixelated fonts, funny ui e.g) that would best provide a nostalgic feeling.

### Users and Characteristics (Physical Limitations)

- **Target Audience:** The people who love playing games, gamers seeking nostalgia.
- **Physical Limitations & Design:** High contrast and fast-flashing pixels found in old 8-bit games might disturb users with visual sensitivity or epilepsy. As a solution, backgrounds were designed in calm, dark tones (dark theme), and animation speeds were optimized. Also, The dark theme is beneficial for vision health.

### User's Works: Goal, Task Analysis and Actions

- **Domain & Goal:** The user's goal is to reach the review, visuals of old game they played in their childhood as quickly as possible.
- **Task Analysis (Scenario & Use Cases):**
  - _Scenario:_ A user wants to read a review of Pac-Man.
  - _Use Case:_ The user enters the "Game Critics" page, finds Pac-Man using the search bar or console/year filters, and clicks on the card to go to the detail page.
- **Actions:** Navigating the menu, checking filter boxes (checkboxes), and using the slider.

### Four Psychological Principles and Three Experience Principles

- **Three Principles from Experience:**
  1. _Visibility:_ The navigation menu (Navbar) is clearly visible everywhere on the site.
  2. _Affordance:_ Filter boxes and game cards are structurally designed to feel clickable by visualizing mouse pointer.
  3. _Feedback:_ Instant visual position change and size change is provided when menu items are clicked or hovered over.
- **Four Psychological Principles:** We designed the site based on users' Mental Models. We added Constraints to prevent incorrect inputs. Finally, we used Mapping and Metaphors (such as retro game items) in the interface.

## Design Part

### Conceptual Design & Content Diagram

By applying the 4-step design process, the following Content Diagram was produced:

1. _HomePage:_ Welcome message, auto-playing retro video, and "Weekly Critics / Our Memories" sliders.
2. _GameList:_ Filters on the left (Console, Year, Rate), game cards on the right.
3. _Content Pages:_ Sub-pages containing game-specific review texts and GIF animations to make it more entertaining.

### Design Principles

- **Simplicity:** Unnecessary texts and inputs were avoided on the page, and direct visuals and information were presented.
- **Structure:** Pages were created with a logical grouping as "Menu -> Content -> Footer".
- **Consistency:** Menu, footer, and button colors are kept strictly the same across all pages (via `main.css`).
- **Tolerance:** In case the user enters the wrong page, returning is made easy with the left-nav menu.

### Critique UI Using the Human-Action Cycle

When evaluating the user's action of "finding the desired game"; the user forms the goal (find Pac-Man), forms the intention (go to the game list), specifies the action (type in search or filter), perceives the system state, and evaluates the outcome (Pac-Man card appears). The cycle is completed smoothly and satisfactorily.

### Interaction Styles and Interface Controls

- **Interaction Styles:** "Menu Selection" and "Form Fill-in" (for the search/filter section) interaction styles were used.
- **Graphical Interface Controls Used and Why:**
  - _Menus (Navbar/Left-Nav):_ It is the main controller because it is the fastest way to switch between pages.
  - _Checkboxes:_ Used on the "Game Critics" page so that users can select multiple console or year filters simultaneously.
  - _Sliders:_ Used on the home page to save screen space and display multiple contents on the horizontal axis.

## Deficiencies

In the project guidelines, it was requested that the website consist of exactly 4 pages. However, our project has a total of 6 pages (HomePage, GameList, Mario, Pacman, Tetris, DonkeyKong). Also, we didn't use bootstrap because we couldn't adapt it to the animated structure. Piling all the visuals, texts, and animations of all games onto a single page would violate the **UI Simplicity principle** and tire the user by greatly extending the page scrolling time. Therefore, each game is divided into its own isolated page.

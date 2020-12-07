# Chess Attack

#### By _**Kaila Sprague McRae & Joseph Nero**_

## 🚩 Description

This application will allow you to enter x & y coordinates for a queen chess piece and an opponent chess piece. The program will then compare the sets of coordinates and determine if the queen is able to attack the opponent piece from their current postions. 

## Specs

<details>

| Test | Input | Output |
| :------------- | :------------- | :------------- |
| **theQueensGambit()**|||
| It will ask the user to enter two sets of coordinates between 1-8 |  |  |
| A instance of a queen class will be created featuring the first set of coordinates | 1,2 | queen.x = 1 , queen.y = 2 |
| A instance of an opp class will be created featuring the second set of coordinates | 1,2 | opp.x = 1 , opp.y = 2 |
| A instance of an opp class will be created featuring the second set of coordinates | 1,2 | opp.x = 1 , opp.y = 2 |
| if the queen has the same x or y coordinate as the opponent, return true | opp.x = 1, queen.x = 1 | true |
| if the difference between the x coordinates and the y coordinates between the queen and the opponent are equal, return true | (queen.x - opp.x) = (queen.y - opp.y) | true |

</details>

## 🔧 Setup/Installation Requirements

### Open Locally

Go to my GitHub repository here, [https://github.com/joey3001/ChessAttackExercise](https://github.com/joey3001/ChessAttackExercise), and click on the green 'Code' button to clone the repository, Open with GitHub Desktop OR Download the ZIP file

##### To clone:
1. Push the green 'Clone' button and copy the URL.
2. Open Terminal or GitBash and input the command: `git clone https://github.com/joey3001/ChessAttackExercise`
3. To view the code, open the copied directory with Visual Studio Code or your preferred text editor by inputing the command `code .` in your terminal.
4. To view the website, open index.html in Chrome or your preferred browser.

## 🐛 Known Bugs

## 📫 Support and contact details

If you run into any problems or have any questions please contact me via [email](mailto:josephnero111@gmail.com).

## 🛠️ Technologies Used

This project uses the following technologies:

- C# 

## 📘 License

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) 2020 Kaila Sprague McRae, Joseph Nero 
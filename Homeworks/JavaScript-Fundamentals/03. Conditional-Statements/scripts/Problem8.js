//Problem 8
function NumberAsWord(number){
    var firstDigit,
        secondDigit,
        thirdDigit;

    if ((number >= 100) && (number <= 999))
    {
        firstDigit = Math.floor(number / 100);
        secondDigit = Math.floor(number / 10) % 10;
        thirdDigit = number % 10;

        switch (firstDigit)
        {
            case 1: firstDigit = "One hundred ";
                break;
            case 2: firstDigit = "Two hundred ";
                break;
            case 3: firstDigit = "Three hundred ";
                break;
            case 4: firstDigit = "Four hundred ";
                break;
            case 5: firstDigit = "Five hundred ";
                break;
            case 6: firstDigit = "Six hundred ";
                break;
            case 7: firstDigit = "Seven hundred ";
                break;
            case 8: firstDigit = "Eight hundred ";
                break;
            case 9: firstDigit = "Nine hundred ";
                break;
            default:
                break;
        }

        switch (secondDigit)
        {
            case 0: secondDigit = "and ";
                break;
            case 1:
            {
                switch (thirdDigit)
                {
                    case 0: thirdDigit = "and ten";
                        break;
                    case 1: thirdDigit = "and eleven";
                        break;
                    case 2: thirdDigit = "and twelve";
                        break;
                    case 3: thirdDigit = "and thirteen";
                        break;
                    case 4: thirdDigit = "and fourteen";
                        break;
                    case 5: thirdDigit = "and fifteen";
                        break;
                    case 6: thirdDigit = "and sixteen";
                        break;
                    case 7: thirdDigit = "and seventeen";
                        break;
                    case 8: thirdDigit = "and eighteen";
                        break;
                    case 9: thirdDigit = "and nineteen";
                        break;
                    default:
                        break;
                }
            }
                break;
            case 2: secondDigit = "and twenty ";
                break;
            case 3: secondDigit = "and thirty ";
                break;
            case 4: secondDigit = "and fourty ";
                break;
            case 5: secondDigit = "and fifty ";
                break;
            case 6: secondDigit = "and sixty ";
                break;
            case 7: secondDigit = "and seventy ";
                break;
            case 8: secondDigit = "and eighty ";
                break;
            case 9: secondDigit = "and ninety ";
                break;
            default:
                break;
        }

        if (secondDigit != 1)
        {
            switch (thirdDigit)
            {
                case 1: thirdDigit = "one";
                    break;
                case 2: thirdDigit = "two";
                    break;
                case 3: thirdDigit = "three";
                    break;
                case 4: thirdDigit = "four";
                    break;
                case 5: thirdDigit = "five";
                    break;
                case 6: thirdDigit = "six";
                    break;
                case 7: thirdDigit = "seven";
                    break;
                case 8: thirdDigit = "eight";
                    break;
                case 9: thirdDigit = "nine";
                    break;
                default: thirdDigit = "";
                    break;
            }
        }
        number = firstDigit + secondDigit + thirdDigit;
    }
    else if ((number >= 21) && (number <= 99))
    {
        firstDigit = Math.floor(number / 10);
        secondDigit = number % 10;
        switch (firstDigit)
        {
            case 2: firstDigit = "Twenty ";
                break;
            case 3: firstDigit = "Thirty ";
                break;
            case 4: firstDigit = "Fourty ";
                break;
            case 5: firstDigit = "Fifty ";
                break;
            case 6: firstDigit = "Sixty ";
                break;
            case 7: firstDigit = "Seventy ";
                break;
            case 8: firstDigit = "Eighty ";
                break;
            case 9: firstDigit = "Ninety ";
                break;
            default:
                break;
        }

        switch (secondDigit)
        {
            case 1: secondDigit = "one";
                break;
            case 2: secondDigit = "two";
                break;
            case 3: secondDigit = "three";
                break;
            case 4: secondDigit = "four";
                break;
            case 5: secondDigit = "five";
                break;
            case 6: secondDigit = "six";
                break;
            case 7: secondDigit = "seven";
                break;
            case 8: secondDigit = "eight";
                break;
            case 9: secondDigit = "nine";
                break;
            default:
                break;
        }
        number = firstDigit + secondDigit;
    }
    else if ((number >= 0) && (number <= 20))
    {
        switch (number)
        {
            case 0: number = "Zero";
                break;
            case 1: number = "One";
                break;
            case 2: number = "Two";
                break;
            case 3: number = "Three";
                break;
            case 4: number = "Four";
                break;
            case 5: number = "Five";
                break;
            case 6: number = "Six";
                break;
            case 7: number = "Seven";
                break;
            case 8: number = "Eight";
                break;
            case 9: number = "Nine";
                break;
            case 10: number = "Ten";
                break;
            case 11: number = "Eleven";
                break;
            case 12: number = "Twelve";
                break;
            case 13: number = "Thirteen";
                break;
            case 14: number = "Fourteen";
                break;
            case 15: number = "Fifteen";
                break;
            case 16: number = "Sixteen";
                break;
            case 17: number = "Seventeen";
                break;
            case 18: number = "Eighteen";
                break;
            case 19: number = "Nineteen";
                break;
            case 20: number = "Twenty";
                break;
            default:
                break;
        }
    }
    console.log(number)
}
console.log('Problem 8:');
console.log('Results:');
NumberAsWord(0);
NumberAsWord(9);
NumberAsWord(10);
NumberAsWord(12);
NumberAsWord(19);
NumberAsWord(25);
NumberAsWord(98);
NumberAsWord(98);
NumberAsWord(273);
NumberAsWord(400);
NumberAsWord(501);
NumberAsWord(617);
NumberAsWord(711);
NumberAsWord(999);
console.log('\n');

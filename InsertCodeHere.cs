﻿using System;
// ReSharper disable UnusedVariable
#pragma warning disable 219

namespace WebShopV06
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            double netPriceBook = 30;
            double netPriceDVD = 50;
            double netPriceGame = 100;

            int noOfBooksInOrder = 23;
            int noOfDVDsInOrder = 16;
            int noOfGamesInOrder = 7;

            double totalNetPrice = netPriceBook * noOfBooksInOrder + netPriceDVD * noOfDVDsInOrder + netPriceGame * noOfGamesInOrder;

            // SO#1
            bool receiveSpecialOffer1 = totalNetPrice > 1000;

            // SO#2
            bool receiveSpecialOffer2 = noOfBooksInOrder >noOfGamesInOrder;

            // SO#3
            bool receiveSpecialOffer3 = (noOfBooksInOrder >= 10) || (noOfDVDsInOrder >= 10) || (noOfGamesInOrder >= 10);

            // SO#4
            bool receiveSpecialOffer4 = ((noOfDVDsInOrder >= 10) && (noOfDVDsInOrder <= 20)) || (noOfGamesInOrder >= 5);

            // SO#5
            bool receiveSpecialOffer5 = receiveSpecialOffer1 == receiveSpecialOffer2 || receiveSpecialOffer1 == receiveSpecialOffer3 || receiveSpecialOffer1 == receiveSpecialOffer4 || receiveSpecialOffer2 == receiveSpecialOffer3 || receiveSpecialOffer2 == receiveSpecialOffer4 || receiveSpecialOffer3 == receiveSpecialOffer4;

            Console.WriteLine($"You ordered {noOfBooksInOrder} books, {noOfDVDsInOrder} DVDs and {noOfGamesInOrder} games");
            Console.WriteLine($"You qualify for special offer #1 : {receiveSpecialOffer1}");
            Console.WriteLine($"You qualify for special offer #2 : {receiveSpecialOffer2}");
            Console.WriteLine($"You qualify for special offer #3 : {receiveSpecialOffer3}");
            Console.WriteLine($"You qualify for special offer #4 : {receiveSpecialOffer4}");
            Console.WriteLine($"You qualify for special offer #5 : {receiveSpecialOffer5}");

            // The LAST line of code should be ABOVE this line
        }
    }
}
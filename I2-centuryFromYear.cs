/* Given a year, return the century it is in. */

int centuryFromYear(int year) {
    if (year % 100 == 0) return year/100;
    else return (year + 100)/100;
}

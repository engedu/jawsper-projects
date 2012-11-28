﻿namespace LogitechLCD
{
    public class Font7x5 : Font
    {
        public Font7x5() : base()
        {
            Init(7);
        }
        protected override void InitCharset()
        {
            SetChar((char)0, "" + "" + "" + "" + "" + "" + "");
            SetChar((char)1, ":" + ":" + ":" + ":" + ":" + ":" + ":");
            SetChar((char)2, "::" + "::" + "::" + "::" + "::" + "::" + "::");
            SetChar((char)3, ":::" + ":::" + ":::" + ":::" + ":::" + ":::" + ":::");
            SetChar((char)4, "::::" + "::::" + "::::" + "::::" + "::::" + "::::" + "::::");
            SetChar((char)5, ":::::" + ":::::" + ":::::" + ":::::" + ":::::" + ":::::" + ":::::");

            SetChar(' ', "::" + "::" + "::" + "::" + "::" + "::" + "::");
            SetChar('!', ":" + "o" + "o" + "o" + ":" + "o" + ":");
            SetChar('\"', ":::" + "o:o" + "o:o" + ":::" + ":::" + ":::" + ":::");
            SetChar('#', ":::::" + ":o:o:" + "ooooo" + ":o:o:" + "ooooo" + ":o:o:" + ":::::");
            SetChar('$', ":::::" + ":oooo" + "o:o::" + ":ooo:" + "::o:o" + "oooo:" + ":::::");
            SetChar('%', ":::::" + ":o:o:" + "ooooo" + ":o:o:" + "ooooo" + ":o:o:" + ":::::");
            SetChar('&', ":::::" + ":oo::" + ":o:::" + ":oo::" + "o::o:" + ":oo:o" + ":::::");
            SetChar('\'', ":" + "o" + "o" + ":" + ":" + ":" + ":");
            SetChar('(', "::" + ":o" + "o:" + "o:" + "o:" + ":o" + "::");
            SetChar(')', "::" + "o:" + ":o" + ":o" + ":o" + "o:" + "::");
            SetChar('*', ":::::" + "o:o:o" + ":ooo:" + "ooooo" + ":ooo:" + "o:o:o" + ":::::");
            SetChar('+', ":::" + ":::" + ":o:" + "ooo" + ":o:" + ":::" + ":::");
            SetChar(',', "::" + "::" + "::" + "::" + ":o" + "o:" + "::");
            SetChar('-', ":::" + ":::" + ":::" + "ooo" + ":::" + ":::" + ":::");
            SetChar('.', ":" + ":" + ":" + ":" + ":" + "o" + ":");
            SetChar('/', ":::" + "::o" + "::o" + ":o:" + "o::" + "o::" + ":::");
            SetChar('1', ":::" + ":o:" + "oo:" + ":o:" + ":o:" + "ooo" + ":::");
            SetChar('2', "::::" + ":oo:" + "o::o" + "::o:" + ":o::" + "oooo" + "::::");
            SetChar('3', ":::" + "oo:" + "::o" + ":oo" + "::o" + "oo:" + ":::");
            SetChar('4', "::::" + "::o:" + ":oo:" + "o:o:" + "oooo" + "::o:" + "::::");
            SetChar('5', ":::" + "ooo" + "o::" + "oo:" + "::o" + "oo:" + ":::");
            SetChar('6', ":::" + ":oo" + "o::" + "ooo" + "o:o" + ":o:" + ":::");
            SetChar('7', ":::" + "ooo" + "::o" + ":o:" + ":o:" + ":o:" + ":::");
            SetChar('8', "::::" + ":oo:" + "o::o" + ":oo:" + "o::o" + ":oo:" + "::::");
            SetChar('9', "::::" + ":oo:" + "o::o" + ":ooo" + ":::o" + "ooo:" + "::::");
            SetChar('0', "::::" + ":oo:" + "o::o" + "o::o" + "o::o" + ":oo:" + "::::");
            SetChar(':', ":" + ":" + "o" + ":" + "o" + ":" + ":");
            SetChar(';', "::" + "::" + ":o" + "::" + ":o" + "o:" + "::");
            SetChar('<', ":::" + "::o" + ":o:" + "o::" + ":o:" + "::o" + ":::");
            SetChar('=', ":::" + ":::" + "ooo" + ":::" + "ooo" + ":::" + ":::");
            SetChar('>', ":::" + "o::" + ":o:" + "::o" + ":o:" + "o::" + ":::");
            SetChar('?', "::::" + ":oo:" + "o::o" + "::o:" + "::::" + "::o:" + "::::");

            SetChar('@', ":::::" + ":ooo:" + "o:::o" + "o:ooo" + "o:o:o" + "::ooo" + ":::::");
            SetChar('A', "::::" + ":oo:" + "o::o" + "oooo" + "o::o" + "o::o" + "::::");
            SetChar('B', "::::" + "ooo:" + "o::o" + "ooo:" + "o::o" + "ooo:" + "::::");
            SetChar('C', ":::" + ":oo" + "o::" + "o::" + "o::" + ":oo" + ":::");
            SetChar('D', "::::" + "ooo:" + "o::o" + "o::o" + "o::o" + "ooo:" + "::::");
            SetChar('E', ":::" + "ooo" + "o::" + "oo:" + "o::" + "ooo" + ":::");
            SetChar('F', ":::" + "ooo" + "o::" + "oo:" + "o::" + "o::" + ":::");
            SetChar('G', "::::" + ":ooo" + "o:::" + "o:oo" + "o::o" + ":oo:" + "::::");
            SetChar('H', "::::" + "o::o" + "o::o" + "oooo" + "o::o" + "o::o" + "::::");
            SetChar('I', ":::" + "ooo" + ":o:" + ":o:" + ":o:" + "ooo" + ":::");
            SetChar('J', ":::" + "::o" + "::o" + "::o" + "::o" + "oo:" + ":::");
            SetChar('K', "::::" + "o::o" + "o:o:" + "oo::" + "o:o:" + "o::o" + "::::");
            SetChar('L', ":::" + "o::" + "o::" + "o::" + "o::" + "ooo" + ":::");
            SetChar('M', ":::::" + "oo:o:" + "o:o:o" + "o:o:o" + "o:::o" + "o:::o" + ":::::");
            SetChar('N', ":::::" + "oo::o" + "oo::o" + "o:o:o" + "o::oo" + "o::oo" + ":::::");
            SetChar('O', "::::" + ":oo:" + "o::o" + "o::o" + "o::o" + ":oo:" + "::::");
            SetChar('P', "::::" + "ooo:" + "o::o" + "ooo:" + "o:::" + "o:::" + "::::");
            SetChar('Q', "::::" + ":oo:" + "o::o" + "o::o" + "o:oo" + ":ooo" + "::::");
            SetChar('R', "::::" + "ooo:" + "o::o" + "ooo:" + "o:o:" + "o::o" + "::::");
            SetChar('S', "::::" + ":ooo" + "o:::" + ":oo:" + ":::o" + "ooo:" + "::::");
            SetChar('T', ":::" + "ooo" + ":o:" + ":o:" + ":o:" + ":o:" + ":::");
            SetChar('U', "::::" + "o::o" + "o::o" + "o::o" + "o::o" + ":ooo" + "::::");
            SetChar('V', ":::::" + "o:::o" + "o:::o" + ":o:o:" + ":o:o:" + "::o::" + ":::::");
            SetChar('W', ":::::" + "o:::o" + "o:::o" + "o:o:o" + "o:o:o" + ":o:o:" + ":::::");
            SetChar('X', ":::::" + "o:::o" + ":o:o:" + "::o::" + ":o:o:" + "o:::o" + ":::::");
            SetChar('Y', "::::" + "o::o" + "o::o" + ":ooo" + ":::o" + ":oo:" + "::::");
            SetChar('Z', ":::::" + "ooooo" + ":::o:" + "::o::" + ":o:::" + "ooooo" + ":::::");
            SetChar('[', "::" + "oo" + "o:" + "o:" + "o:" + "oo" + "::");
            SetChar('\\', ":::" + "o::" + "o::" + ":o:" + "::o" + "::o" + ":::");
            SetChar(']', "::" + "oo" + ":o" + ":o" + ":o" + "oo" + "::");
            SetChar('^', ":::" + ":o:" + "o:o" + ":::" + ":::" + ":::" + ":::");
            SetChar('_', ":::" + ":::" + ":::" + ":::" + ":::" + "ooo" + ":::");

            SetChar('`', "::" + "o:" + ":o" + "::" + "::" + "::" + "::");
            SetChar('a', ":::" + ":::" + "oo:" + "::o" + "o:o" + ":oo" + ":::");
            SetChar('b', "::::" + "o:::" + "ooo:" + "o::o" + "o::o" + "ooo:" + "::::");
            SetChar('c', ":::" + ":::" + ":oo" + "o::" + "o::" + ":oo" + ":::");
            SetChar('d', "::::" + ":::o" + ":ooo" + "o::o" + "o::o" + ":ooo" + "::::");
            SetChar('e', ":::" + ":::" + ":o:" + "o:o" + "o::" + ":oo" + ":::");
            SetChar('f', "::" + ":o" + "o:" + "oo" + "o:" + "o:" + "::");
            SetChar('g', "::::" + "::::" + ":ooo" + "o::o" + ":ooo" + ":::o" + "ooo:");
            SetChar('h', ":::" + "o::" + "o::" + "oo:" + "o:o" + "o:o" + ":::");
            SetChar('i', ":" + "o" + ":" + "o" + "o" + "o" + ":");
            SetChar('j', ":::" + "::o" + ":::" + "::o" + "::o" + "oo:" + ":::");
            SetChar('k', ":::" + "o::" + "o:o" + "oo:" + "o:o" + "o:o" + ":::");
            SetChar('l', ":" + "o" + "o" + "o" + "o" + "o" + ":");
            SetChar('m', ":::::" + ":::::" + "oooo:" + "o:o:o" + "o:o:o" + "o:o:o" + ":::::");
            SetChar('n', ":::" + ":::" + "oo:" + "o:o" + "o:o" + "o:o" + ":::");
            SetChar('o', "::::" + "::::" + ":oo:" + "o::o" + "o::o" + ":oo:" + "::::");
            SetChar('p', "::::" + "::::" + "ooo:" + "o::o" + "ooo:" + "o:::" + "::::");
            SetChar('q', "::::" + "::::" + ":ooo" + "o::o" + ":ooo" + ":::o" + "::::");
            SetChar('r', "::" + "::" + "oo" + "o:" + "o:" + "o:" + "::");
            SetChar('s', ":::" + ":::" + ":oo" + "o::" + "::o" + "oo:" + ":::");
            SetChar('t', "::" + "o:" + "oo" + "o:" + "o:" + ":o" + "::");
            SetChar('u', ":::" + ":::" + "o:o" + "o:o" + "o:o" + ":oo" + ":::");
            SetChar('v', ":::" + ":::" + "o:o" + "o:o" + ":o:" + ":o:" + ":::");
            SetChar('w', ":::::" + ":::::" + "o:o:o" + "o:o:o" + ":o:o:" + ":o:o:" + ":::::");
            SetChar('x', ":::" + ":::" + "o:o" + ":o:" + ":o:" + "o:o" + ":::");
            SetChar('y', ":::" + ":::" + "o:o" + "o:o" + ":o:" + ":o:" + "o::");
            SetChar('z', ":::" + ":::" + "ooo" + "::o" + "o::" + "ooo" + ":::");
            SetChar('{', ":::" + ":oo" + ":o:" + "oo:" + ":o:" + ":oo" + ":::");
            SetChar('|', ":" + "o" + "o" + "o" + "o" + "o" + ":");
            SetChar('}', ":::" + "oo:" + ":o:" + ":oo" + ":o:" + "oo:" + ":::");
            SetChar('~', ":::" + ":::" + ":::" + ":::" + ":::" + ":::" + ":::");

            SetChar('À', "o:::" + ":o::" + ":oo:" + "o::o" + "oooo" + "o::o" + "::::");
            SetChar('Ä', "o::o" + "::::" + ":oo:" + "o::o" + "oooo" + "o::o" + "::::");
            SetChar('Á', ":::o" + "::o:" + ":oo:" + "o::o" + "oooo" + "o::o" + "::::");

            SetChar('È', 'E'); SetChar('Ë', 'E'); SetChar('É', 'E');
            SetChar('Ì', 'I'); SetChar('Ï', 'I'); SetChar('Í', 'I');
            SetChar('Ò', 'O'); SetChar('Ö', 'O'); SetChar('Ó', 'O');
            SetChar('Ù', 'U'); SetChar('Ü', 'U'); SetChar('Ú', 'U');

            SetChar('à', "o::" + ":o:" + "oo:" + "::o" + "o:o" + ":oo" + ":::");
            SetChar('ä', "o:o" + ":::" + "oo:" + "::o" + "o:o" + ":oo" + ":::");
            SetChar('á', "::o" + ":o:" + "oo:" + "::o" + "o:o" + ":oo" + ":::");

            SetChar('è', "o::" + ":o:" + ":o:" + "o:o" + "o::" + ":oo" + ":::");
            SetChar('ë', "o:o" + ":::" + ":o:" + "o:o" + "o::" + ":oo" + ":::");
            SetChar('é', "::o" + ":o:" + ":o:" + "o:o" + "o::" + ":oo" + ":::");

            SetChar('ì', "o:" + ":o" + "::" + ":o" + ":o" + ":o" + "::");
            SetChar('ï', ":::" + "o:o" + ":::" + ":o:" + ":o:" + ":o:" + ":::");
            SetChar('í', ":o" + "o:" + "::" + "o:" + "o:" + "o:" + "::");

            SetChar('ò', "o:::" + ":o::" + "::::" + ":oo:" + "o::o" + ":oo:" + "::::");
            SetChar('ö', "::::" + "o::o" + "::::" + ":oo:" + "o::o" + ":oo:" + "::::");
            SetChar('ó', ":::o" + "::o:" + "::::" + ":oo:" + "o::o" + ":oo:" + "::::");

            SetChar('ù', "o::" + ":o:" + ":::" + "o:o" + "o:o" + ":oo" + ":::");
            SetChar('ü', ":::" + "o:o" + ":::" + "o:o" + "o:o" + ":oo" + ":::");
            SetChar('ú', "::o" + ":o:" + ":::" + "o:o" + "o:o" + ":oo" + ":::");

            SetChar('æ', ":::::" + ":::::" + "oo:o:" + "::o:o" + "o:o::" + ":o:oo" + ":::::");
            SetChar('œ', ":::::" + ":::::" + ":o:o:" + "o:o:o" + "o:o::" + ":o:oo" + ":::::");
        }
    }
    public class Font7x5Time : Font
    {
        public Font7x5Time()
            : base()
        {
            Init(7);
        }
        protected override void InitCharset()
        {
            SetChar((char)0, "" + "" + "" + "" + "" + "" + "");

            SetChar(':', ":" + ":" + "o" + ":" + "o" + ":" + ":");
            SetChar('1', ":::::" + "::o::" + ":oo::" + "::o::" + "::o::" + ":ooo:" + ":::::");
            SetChar('2', ":::::" + ":ooo:" + "o:::o" + "::oo:" + ":o:::" + "ooooo" + ":::::");
            SetChar('3', ":::::" + "oooo:" + "::::o" + "::oo:" + "::::o" + "oooo:" + ":::::");
            SetChar('4', ":::::" + "o::::" + "o::o:" + "ooooo" + ":::o:" + ":::o:" + ":::::");
            SetChar('5', ":::::" + "ooooo" + "o::::" + "oooo:" + "::::o" + "oooo:" + ":::::");
            SetChar('6', ":::::" + ":oooo" + "o::::" + "oooo:" + "o:::o" + ":ooo:" + ":::::");
            SetChar('7', ":::::" + "ooooo" + "::::o" + ":::o:" + "::o::" + "::o::" + ":::::");
            SetChar('8', ":::::" + ":ooo:" + "o:::o" + ":ooo:" + "o:::o" + ":ooo:" + ":::::");
            SetChar('9', ":::::" + ":ooo:" + "o:::o" + ":oooo" + "::::o" + ":ooo:" + ":::::");
            SetChar('0', ":::::" + ":ooo:" + "o::oo" + "o:o:o" + "oo::o" + ":ooo:" + ":::::");
            SetChar(' ', ":::::" + ":::::" + ":::::" + ":::::" + ":::::" + ":::::" + ":::::");
            SetChar('/', ":::::" + "::::o" + ":::o:" + "::o::" + ":o:::" + "o::::" + ":::::");
        }
    }
}
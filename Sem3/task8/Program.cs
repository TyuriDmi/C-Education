string Replace(string Text, char OldArg, char NewArg2) {
string NewText = String.Empty;
int length = Text.Length;
for (int i = 0; i < length; i++) {
    if (Text[i] == OldArg) {NewText = NewText + $"{NewArg2}";}
    else {NewText = NewText + $"{Text[i]}";}
    }
return NewText;
}

Console.WriteLine("Введите текст");
string NewLetters = Replace((Console.ReadLine()), 'f', 'F');
Console.WriteLine(NewLetters);

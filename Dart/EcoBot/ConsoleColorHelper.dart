class Consolecolorhelper {
  String verde = '\x1B[32m';
  String bianco = '\x1B[37m';

  String? coloraTxt(String line) {
    for (var i = 0; i < line.length - 7; ++i) {
      String temp =
          line[i] +
          line[i + 1] +
          line[i + 2] +
          line[i + 3] +
          line[i + 4] +
          line[i + 5] +
          line[i + 6] +
          line[i + 7];

      if (temp == '\\x1B[32m') {
        line = line.replaceRange(i, i + 8, verde);
      } else if (temp == "\\x1B[37m") {
        line = line.replaceRange(i, i + 8, bianco);
      }
    }
    return line;
  }
}

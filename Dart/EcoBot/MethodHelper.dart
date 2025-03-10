class Methodhelper {
  bool checkForValidInput(String d) {
    if (d.compareTo('0') == 0 ||
        d.compareTo('1') == 0 ||
        d.compareTo('2') == 0 ||
        d.compareTo('3') == 0) {
      return false;
    }
    return true;
  }
}

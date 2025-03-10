import 'dart:io';
import 'MethodHelper.dart';
import 'consoleColorHelper.dart';
import 'FileDefinition.dart';

Consolecolorhelper console = Consolecolorhelper();
Filedefinition file = Filedefinition();
Methodhelper methodhelper = Methodhelper();

//        BLOCCO DATI

bool altreDomande = true;
var domande = Map<int, dynamic>();
var risposte = Map<int, dynamic>();

//  TOPIC

List<String> argomenti = file.fTopic.readAsLinesSync();

//  DOMANDE

List<String> dNoPoverty = file.qNoPoverty.readAsLinesSync();
List<String> dZeroHunger = file.qZeroHunger.readAsLinesSync();
List<String> dGoodHealthAndWellBeing =
    file.qGoodHealthAndWellBeing.readAsLinesSync();
List<String> dQualityEducation = file.qQualityEducation.readAsLinesSync();

//  RISPOSTE

var rNoPoverty = [
  file.fNoPoverty1,
  file.fNoPoverty2,
  file.fNoPoverty3,
  file.fNoPoverty4,
];

var rZeroHunger = [
  file.fZeroHunger1,
  file.fZeroHunger2,
  file.fZeroHunger3,
  file.fZeroHunger4,
];

var rGoodHealthAndWellBeing = [
  file.fGoodHealthAndWellBeing1,
  file.fGoodHealthAndWellBeing2,
  file.fGoodHealthAndWellBeing3,
  file.fGoodHealthAndWellBeing4,
];

var rQualityEducation = [
  file.fQualityEducation1,
  file.fQualityEducation2,
  file.fQualityEducation3,
  file.fQualityEducation4,
];

//  FINE RISPOSTE

//        FINE BLOCCO DATI

void main() {
  //        SETUP MAPPE

  domande[0] = dNoPoverty;
  domande[1] = dZeroHunger;
  domande[2] = dGoodHealthAndWellBeing;
  domande[3] = dQualityEducation;

  risposte[0] = rNoPoverty;
  risposte[1] = rZeroHunger;
  risposte[2] = rGoodHealthAndWellBeing;
  risposte[3] = rQualityEducation;

  //        INTRODUZIONE AL BOT

  print(
    '\nCiao, il mio nome è \x1B[32mEcoBot\x1B[0m.\nSono stato creato per rispondere a domande '
    'riguardanti la sostenibilità. Puoi scegliere\ntra diversi macro argomenti '
    'per poi selezionare la domanda che più cattura il tuo interesse.\nIniziamo!!\n',
  );

  while (altreDomande == true) {
    print(
      'Come detto in precedenza ci sono diverse categorie tra cui poter scegliere. '
      'Eccole qui di seguito : \n',
    );

    for (var i = 0; i < argomenti.length; ++i) {
      print('\x1B[32m$i : ${argomenti[i]}\x1B[0m');
    }

    print(
      '\nSe una tematica è di tuo interesse inserisci il \x1B[31mNUMERO\x1B[0m'
      " corrispondente per approfondire di più\nsull'argomento,"
      ' altrimenti digita \x1B[31mSTOP\x1B[0m per fermare il bot.',
    );

    String tematica = 'ok';
    bool input = true;

    while (input) {
      tematica = (stdin.readLineSync()!).toUpperCase();
      input = methodhelper.checkForValidInput(tematica);
      if (input == true) {
        print(
          '\nNon hai inserito un valore accetabile. Puoi ripetere per favore?',
        );
      }
    }

    if (!(tematica.compareTo('STOP') == 0)) {
      int tematicaIndex = int.parse(tematica);

      print(
        '\nHai scelto : \x1B[32m${argomenti[tematicaIndex]}\x1B[0m'
        '\nQueste sono tutte le domande relative disponibili nel mio database :\n',
      );

      for (var i = 0; i < domande[tematicaIndex].length; ++i) {
        print('\x1B[32m$i : ${(domande[tematicaIndex])[i]}\x1B[0m');
      }
      print(
        '\nPer pormi la domanda inserisci il \x1B[31mNUMERO\x1B[0m corrispondente!!',
      );
      String sDomandaIndex = 'ok';

      bool input2 = true;
      while (input2) {
        sDomandaIndex = stdin.readLineSync()!;
        input2 = methodhelper.checkForValidInput(sDomandaIndex);
        if (input2 == true) {
          print(
            '\nNon hai inserito un valore accetabile. Puoi ripetere per favore?',
          );
        }
      }

      int domandaIndex = int.parse(sDomandaIndex);
      print(
        '\nLa tua domanda è : \x1B[32m${domande[tematicaIndex][domandaIndex]}\x1B[0m'
        '\nSecondo quello che ho nel database posso dirti che : \n',
      );

      //   LEGGE DAL FILE SELEZIONATO LA RISPOSTA DA DARE ALL'UTENTE

      List<String> lines =
          risposte[tematicaIndex][domandaIndex].readAsLinesSync();

      for (var i = 0; i < lines.length; ++i) {
        String? line = lines[i];
        line = console.coloraTxt(line);
        print(line);
      }

      print(
        'Ci sono altre domande che vuoi pormi? Sono qui per te...'
        ' Rispondi con \x1B[31mSI\x1B[0m per continuare,\noppure \x1B[31mNO\x1B[0m per interrompere.',
      );

      //    RESTART DEL BOT OPPURE OUT

      String continua = 'oki';

      bool input3 = true;

      while (input3) {
        continua = (stdin.readLineSync()!).toUpperCase();

        if (continua.compareTo("SI") == 0 || continua.compareTo("NO") == 0) {
          input3 = false;
        } else {
          print('\nHai inserito un valore non valido. Puoi ripetere?');
        }
      }

      if (continua.compareTo('NO') == 0) {
        altreDomande = false;
        print(
          "\nE' stato un piacere rispondere alle tue domande. Per qualsiasi altro dubbio sono qui!!",
        );
      } else {
        print('\nBene, allora ricominciamo!!');
      }
    } else {
      altreDomande = false;
    }
  }
}

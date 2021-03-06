﻿
using System.Windows.Input;
using Chess0.Helper;
using Chess0.ViewModel.Rules.Chess;
using Chess0.ViewModel.Rules.Checkers;

namespace Chess0.ViewModel
{
    enum Game {Chess,Checkers}

    class MainWindowViewModel :  NotifyPropertyChanged
    {

        #region Proprties

        private BaseBoardGameViewModel boardviewmodel;
        public BaseBoardGameViewModel BoardViewModel
        {
            get
            {
                return boardviewmodel;
            }
            set
            {
                boardviewmodel = value;
                OnPropertyChanged("BoardViewModel");
            }
        }

        private ICommand choosegame;
        public ICommand ChooseGame
        {
            get { return choosegame; }
            set { choosegame = value; }
        }

        private ICommand restart_game_command;
        public ICommand RestartGameCommand
        {
            get
            {
                return restart_game_command;
            }
            set
            {
                restart_game_command = value;
                OnPropertyChanged("RestartGameCommand");
            }
        }

        private string gamename;
        public string GameName
        {
            get => gamename; 
            
            set
            {
                gamename = value;
                OnPropertyChanged("GameName");
            }
        }

        #endregion

        #region constructor
        public MainWindowViewModel()
        {
       
            BoardViewModel = new ChessBoardViewModel(new Rules_Chess());
            ChooseGame = new RelayCommand(OnChooseGame);
            GameName = "Chess Game";
            RestartGameCommand = BoardViewModel.RestartCommand;

        }

        #endregion constructor

        #region Command
        private void OnChooseGame(object game)
        {
            
            if (Game.Chess.ToString() == game as string && GameName != "Chess Game")
            {
                BoardViewModel = new ChessBoardViewModel(new Rules_Chess());
                GameName = "Chess Game";


            }
            else if (Game.Checkers.ToString() == game as string && GameName!= "Checkers Game")
            {
                BoardViewModel = new CheckersBoardViewModel(new Rules_Checkers());
                GameName = "Checkers Game";
            }
            RestartGameCommand = BoardViewModel.RestartCommand;
        }
        #endregion Command
    }


}

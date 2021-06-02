﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace TCPClient {
    class EmptyPiece : ChessPiece{

        public EmptyPiece() : base("Empty", "Empty"){

        }

        public override bool IsValidMove(int dx, int dy, int i1, int i2, List<ChessPiece> board){
            return false;
        }
    }
}

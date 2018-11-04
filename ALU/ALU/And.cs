﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALU {
	public class And {
		public bool Ativa(bool A, bool B) {
			return (A & B);
		}
	}

	public class And3 {
		public bool Ativa(bool A, bool B, bool C) {
			return (A & B & C);
		}
	}

	public class Not {
		public bool Ativa(bool A) {
			return (!A);
		}
	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals {
    internal class AnimalClass {
		public AnimalClass() {
			InitializeClasses();
		}

		private List<string> animalClasses;

		public List<string> AnimalClasses {
			get { return animalClasses; }
		}

		public void AddAnimalClass(string animalClass) {
			AnimalClasses.Add(animalClass);
		}

		private void InitializeClasses() {
			animalClasses = new List<string>();
		}
	}
}

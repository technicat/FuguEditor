using UnityEngine;
using System.Collections;
using UnityEditor;

using System.Linq;

namespace Fugu.Editor {


public class Screenshot {

	[MenuItem ("FuguGames/Screenshot/Take")]
	static void Take() {
		ScreenCapture.CaptureScreenshot("unityscreenshot.png");
	}

		

}
}
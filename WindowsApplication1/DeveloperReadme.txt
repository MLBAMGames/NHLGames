Potential issues:
	- Don't use MetroTextBox controls on any forms, for some reason they have a habit of corrupting the designer leaving it unable to render the form.
	- Sometimes the designer get confused if you make any changes to the controls in the "Controls" folder and adds a namespace to the designer's control inititializer. 
	  Ie. In the designer it make try to put "control = new NHLGames.BorderPanel", in order to fix that you need to remove the name space, leaving you with "control = new BorderPanel".
	- Building the installer likely requires you to have this extension in Visual Studio: https://visualstudiogallery.msdn.microsoft.com/f1cc3f3e-c300-40a7-8797-c509fb8933b9?SRC=VSIDE
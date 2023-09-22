# ObjToPicoCAD-GUI

ObjToPicoCAD-GUI is a user-friendly graphical user interface (GUI) application written in C# that serves as a port for the original C++ script by [shinamu476/obj2picoCAD](https://github.com/shinamu476/obj2picoCAD). This application simplifies the process of converting 3D models in OBJ format into PicoCAD-compatible files while providing a range of customizable options.

![img](https://i.imgur.com/y0Mfdhu.png?1)

## Usage

To use ObjToPicoCAD-GUI, follow these steps:

1. **Download and Install**:

   - Make sure you have the [.NET runtime](https://dotnet.microsoft.com/download/dotnet) installed on your system.
   - Clone or download the ObjToPicoCAD-GUI repository from [your repository URL].
   - Build and run the application using your preferred development environment or run the precompiled executable if available.

2. **User Interface**:

   The application's user interface is designed to simplify the conversion process. Here's an overview of the input fields and options available:

   - **Obj Path**: Specify the path to the OBJ file you want to convert.

   - **Export Path**: Set the destination directory where the converted PicoCAD files will be saved.

   - **Size**: Define the size of the PicoCAD model. This determines the scale of the output.

   - **Zoom Level**: Adjust the zoom level for the model within PicoCAD.

   - **Flip Normals**: Toggle between "True" or "False" to flip normals during the conversion process. Choose "True" if your model appears inside-out.

   - **Background Color**: Select a color from the PICO-8 Color Palette to set the background color for the PicoCAD model.

   - **Alpha Color**: Define the alpha (transparency) color for the model.

   - **Offset**: Set an offset for the model's position within PicoCAD.

   - **Light Direction**: Specify the direction of the light source for shading the model.

   - **Recent Files List**: ObjToPicoCAD-GUI tracks recent export settings for your convenience. You can quickly load previous settings from the recent files list.

3. **Conversion Process**:

   Once you have configured the desired settings, click the "Convert" button to start the conversion process. The application will convert the OBJ file into a txt file PicoCAD-compatible format based on your specified settings.

4. **Review Output**:

   After the conversion is complete, ObjToPicoCAD-GUI will automatically open the export file directory and select the converted PicoCAD-compatible file for you. This streamlined process allows you to quickly access the output without the need to manually navigate to   the export path. You can then effortlessly load the selected file into PicoCAD for further editing and use in your PICO-8 projects.
   ##
![gif](https://i.imgur.com/qe4KQVb.gif)

![gif](https://i.imgur.com/PJ59wCB.gif)

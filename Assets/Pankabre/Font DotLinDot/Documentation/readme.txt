DotLinDot

TTF OpenType v1.0.1

How to install the font into Unity:

1. Import Unity TextMeshPro package.
2. Import DotLinDot font unitypackage.
3. Select imported ttf font.
4. In font inspector on the right click on three vertical dots and then select Create TMP Font Asset.
5. Change Character Set to Unicode Range (Hex) and write 0-ffff to Character Sequence (Hex) field.
6. Set render mode to SDF16, SDF32, SDFAA or SDFAA_HINTED.
7. Check Get kerning pairs checkbox.
8. Click on Generate Font Atlas and save the font asset.


Tips for better render quality:

1. Use SDF32 render mode.
2. Increase Atlas resolution to 1024x1024 or 2048x2048.
3. Limit characters in font by setting Character Set to Unicode Range (Hex) and use Character Sequence field. (for example: 20-5A,5C,5F,61-7A,A0,A9,AE)


How to use the font:

1. Place the GameObject with TextMeshPro - Text (UI) component into the scene.
2. Select generated Font Asset.








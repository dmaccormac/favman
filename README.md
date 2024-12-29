# Favman - Customize bookmark icons

Easily create HTML bookmark files with custom icons.

## Usage
Provide a title, URL and icon file and the program will generate a HTML file.

Output files are saved to the `%APPDATA%\Favman\Bookmarks` directory.

The icon file will be copied to the output directory and referenced in the HTML file to be used as the bookmark icon.

The default timeout is 5 seconds, to allow time to bookmark the page before the redirect is triggered.

The redirect timeout setting can be adjusted here:
```html
<meta http-equiv=""refresh"" content=""5;url={url}"">
```




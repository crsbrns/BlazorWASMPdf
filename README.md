# Introduction 
Example of generating a pdf from Blazor WASM application that uses Chart.js. Uses Puppeteer on a web api endpoint to run the supplied url on a headless version of Chrome. 

# Getting Started
Run both projects (.Web and .WebApi)

# Build and Test
Click 'Generate Pdf' button
First generation of pdf will take quite a while as Puppeteer needs to download a local version of Chromium to run
Check root of .WebApi project for the generated pdf ('[Guid].pdf')  
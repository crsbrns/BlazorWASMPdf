# Blazor WASM and Pdfs

Use Puppeteer to generate a pdf from a Blazor WASM application that renders js charts 

## About
Encountered this problem when trying to create a pdf of page in a Blazor WASM application. The page fetched a significant amount of data then rendered some complex charts via JS interop and Chart.js. This solution uses Puppeteer on a web api endpoint to run the supplied url on a headless version of Chrome, with the ability to wait for the chart element to render before creating the pdf. 

## Prerequisites
 - .NET 7

## Getting started
Alter the startup configuration to run both projects (.Web and .WebApi)

## How to test
Click 'Generate Pdf' button once the web and api have loaded
> First launch of the web api may take longer than usual as Puppeteer downloads a local version of Chromium to run
The generated pdf ('[Guid].pdf'), which should include the JS rendered chart, will created at the .WebApi project root

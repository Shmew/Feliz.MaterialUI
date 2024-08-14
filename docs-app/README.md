# Feliz.MaterialUI docs/demo app


## Development

Before doing anything, start with installing npm dependencies using `pnpm install` or `npm install` command depending on the used package manager ([pnpm](https://pnpm.io) or [npm](https://www.npmjs.com/package/npm)).

Then to start development mode with hot module reloading, run:
```bash
pnpm start
```
or
```bash
npm start
```
This will start the development server after compiling the project, once it is finished, navigate to [http://localhost:48080](http://localhost:48080) to view the application .

To build the application and make ready for production:
```bash
pnpm run build
```
or
```bash
npm run build
```
This command builds the application and puts the generated files into the `deploy` directory (can be overwritten in webpack.config.js).

<!--### Tests

The template includes a test project that ready to go which you can either run in the browser in watch mode or run in the console using node.js and mocha. To run the tests in watch mode:
```
npm run test:live
```
This command starts a development server for the test application and makes it available at http://localhost:8085.

To run the tests using the command line and of course in your CI server, you have to use the mocha test runner which doesn't use the browser but instead runs the code using node.js:
```
npm test
```-->

Publishing
----------

To publish, run this command:

```bash
pnpm run build && node publish.js
```
or
```bash
npm run build && node publish.js
```

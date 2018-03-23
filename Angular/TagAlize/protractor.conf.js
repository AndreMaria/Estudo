// Protractor configuration file, see link for more information
// https://github.com/angular/protractor/blob/master/lib/config.ts

//require('./e2e/features/step_definitions/*steps.js')
require('./e2e/features/teste')

exports.config = {
  allScriptsTimeout: 11000,
  directConnect: true,
  baseUrl: 'http://localhost:4200/',
  framework: 'custom',
  frameworkPath: require.resolve('protractor-cucumber-framework'),
  specs: [
    '.e2e/features/*.feature'
  ],
  capabilities: {
    'browserName': 'chrome'
  },
  cucumberOpts: {
    require: './e2e/features/step_definitions/*steps.js',
    tags: false,
    showColors: true,
    profile: false,
    'no-source': true
  }
};

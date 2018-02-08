
exports.config = {
  defaultTimeoutInterval: 25000,
  getPageTimeout: 60000,
  allScriptsTimeout: 500000,
  framework: 'custom',
  frameworkPath: require.resolve('protractor-cucumber-framework'),
  capabilities: {
      'browserName': 'chrome',
  },

  specs: [
      './e2e/features/login/*.feature'
  ],

  baseURL: 'http://localhost:4200/',

  cucumberOpts: {
      format: ['json:reports/results.json', 'pretty'],
      require: [
        './e2e/features/stepdefinition/*steps.js',
        './e2e/support/env.js'
      ],
      profile: false,
      'no-source': true
  },
  resultJsonOutputFile: './e2e/results/results.json'
}

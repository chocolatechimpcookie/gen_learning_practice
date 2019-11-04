// import requirements
require('chromedriver');
const assert = require('assert');
const {Builder, Key, By, until} = require('selenium-webdriver');

describe('Checkout Google', function()
{
    let driver;

    before(async function()
    {
      driver = await new Builder().forBrowser('firefox').build();
    });

//tests
  it('Search on Google', async function()
  {
    await driver.get("https://google.com");
    await driver.findElement(By.id('lst-ib')).click();
    await driver.findElement(By.id('lst-ib')).sendKeys('dalenguyen', Key.RETURN);
    await driver.wait(until.elementLocated(By.id('rcnt')),10000);
    let title = await driver.getTitle();
    assert.equal(title, 'dalenguyen - Google Search');
  });

  after(() => driver && driver.quit());
})

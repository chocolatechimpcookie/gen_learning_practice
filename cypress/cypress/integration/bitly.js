describe('My First Test', function()
{
  it('Bitly website loads properly by displaying form and various messages', function()
  {
    cy.visit('https://bitly.com/');

    //Expect
    cy.contains('Get the edge you need with links you can trust');
    cy.get("input#shorten_url").should('be.visible');
  })

  it('Bitly detects proper url and displays new link', function()
  {
    cy.visit('https://bitly.com/');
    cy.get('#banner-cookie--button').click();
    cy.get('input#shorten_url').type("http://www.distrowatch.com");
    cy.wait(2000);
    cy.get('input#shorten_btn').focus().invoke('mouseover').click();

    // Expect
    cy.get('ul#most_recent_links').contains('www.distrowatch.com');
    cy.get('button#shortened_btn').contains("Copy");

  })

  it('Bitly detects improper url by showing an error message and then making the message invisible', function()
  {
    cy.visit('https://bitly.com/');
    cy.get('input#shorten_url').click().type("Random gibberish that's not a link");
    cy.wait(2000);
    cy.get('input#shorten_btn').focus().invoke('mouseover').click();
    cy.get('input#shorten_btn').focus().invoke('mouseover').click();
    cy.get('input#shorten_btn').focus().invoke('mouseover').click();

    //Expect
    cy.contains("Unable to shorten that link. It is not a valid url.")
    cy.wait(3000);
    cy.get('ul#most_recent_links').should('be.empty');
  })

})

// cy.get('input#shorten_url').type("http://www.distrowatch.com{enter}");
// cy.get('input#shorten_btn').trigger('mouseover');
// cy.get('input#shorten_btn').click();
// cy.get('#ShortenedForm').submit();
// cy.get('#unAuthShortenForm').submit();

describe('Тест на додавання контакту', () => {
  it('додає новий контакт', () => {
    cy.visit('http://localhost:5173');

    cy.get('input[placeholder="Ім\'я"]').type('John Doe');
    cy.get('input[placeholder="Телефон"]').type('1234567890');

    cy.contains('Додати').click();

    cy.get('.contacts-list li').should('have.length', 1);
    cy.get('.contacts-list li').first().should('contain', 'John Doe - 1234567890');
  });
});
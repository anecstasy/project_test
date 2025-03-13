describe('Тест на видалення контакту', () => {
  it('видаляє контакт', () => {
    cy.visit('http://localhost:5173');

    cy.get('input[placeholder="Ім\'я"]').type('John Doe');
    cy.get('input[placeholder="Телефон"]').type('1234567890');
    
    cy.contains('Додати').click();

    cy.get('.contacts-list li').first().contains('Видалити').click();

    cy.get('.contacts-list li').should('have.length', 0);
  });
});
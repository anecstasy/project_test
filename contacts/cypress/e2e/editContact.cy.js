describe('Тест на редагування контакту', () => {
  it('редагує існуючий контакт', () => {
    cy.visit('http://localhost:5173');

    cy.get('input[placeholder="Ім\'я"]').type('John Doe');
    cy.get('input[placeholder="Телефон"]').type('1234567890');
    
    cy.contains('Додати').click();

    cy.get('.contacts-list li').first().contains('Редагувати').click();
    
    cy.get('input[placeholder="Ім\'я"]').clear().type('Jane Doe');
    cy.get('input[placeholder="Телефон"]').clear().type('0987654321');

    cy.contains('Редагувати').click();

    cy.get('.contacts-list li').first().should('contain', 'Jane Doe - 0987654321');
  });
});
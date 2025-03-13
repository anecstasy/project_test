describe('Тест на сортування контактів', () => {
  it('сортує контакти за іменем', () => {
    cy.visit('http://localhost:5173');

    cy.get('input[placeholder="Ім\'я"]').type('John Doe');
    cy.get('input[placeholder="Телефон"]').type('1234567890');

    cy.contains('Додати').click();
  
    cy.get('input[placeholder="Ім\'я"]').type('Alice Smith');
    cy.get('input[placeholder="Телефон"]').type('0987654321');

    cy.contains('Додати').click();
  
    cy.contains('Сортувати за іменем').click();
  
    cy.get('.contacts-list li').first().should('contain', 'Alice Smith - 0987654321');
    cy.get('.contacts-list li').last().should('contain', 'John Doe - 1234567890');
  });
  
  it('сортує контакти за телефоном', () => {
    cy.visit('http://localhost:5173');
    
    cy.get('input[placeholder="Ім\'я"]').type('John Doe');
    cy.get('input[placeholder="Телефон"]').type('1234567890');
    cy.contains('Додати').click();
  
    cy.get('input[placeholder="Ім\'я"]').type('Alice Smith');
    cy.get('input[placeholder="Телефон"]').type('0987654321');
    cy.contains('Додати').click();
  
    cy.contains('Сортувати за телефоном').click();
  
    cy.get('.contacts-list li').first().should('contain', 'Alice Smith - 0987654321');
    cy.get('.contacts-list li').last().should('contain', 'John Doe - 1234567890');
  });
});
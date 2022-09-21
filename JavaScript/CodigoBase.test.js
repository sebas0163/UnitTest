const division = require('./CodigoBase')

test('Divide correctamente', ()=>{
    expect(division(10,2)).toBe(5)
})
test('Toma en cuenta la división entre 0', ()=>{
    expect(division(10,0)).toBe(0)
})
# 🐾 EduCat

## 📚 Tecnologias utilizadas

<div align="center">
    <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dotnetcore/dotnetcore-original.svg" alt=".NET Core" width="60" height="60" title=".NET Core"/>
    <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/postgresql/postgresql-original.svg" alt="PostgreSQL" width="60" height="60" title="PostgreSQL"/>
    <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/typescript/typescript-original.svg" alt="TypeScript" width="60" height="60" title="TypeScript"/>
    <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/vuejs/vuejs-original.svg" alt="Vue.js" width="60" height="60" title="Vue.js"/>
</div>

## ⚙️ Processos Principais

Cadastros de professor e aluno serão feitos pelo usuário administrador

1. **Curso**
    - Cada curso pode conter várias disciplinas

2. **Disciplina**
    - Criada dentro de um curso
    - Pode ter várias turmas associadas

3. **Turma**
    - Associada a uma disciplina
    - É a instância da disciplina oferecida em um determinado período
    - Vincula professor responsável
    - Matricula alunos participantes do período

4. **Professor**
    - Ver suas informações pessoais
    - Ver turmas a que está vinculado
    - Lançar notas
    - Criar atividades
        - Ver atividades entregues
    - Adicionar conteúdo nas turmas em que leciona
        - Adicionar seções na disciplina
        - Adicionar avaliações e aplicar pelo sistema
        - Adicionar arquivos anexos (PDFs, imagens)
        - Adicionar links de vídeos que possam ser assistidos sem sair da plataforma

5. **Aluno**
    - Ver suas informações pessoais
    - Ver turmas a que está vinculado
        - Ver atividades
        - Entregar atividades
    - Ver notas

6. **Atividades**
    - Criadas dentro de uma turma
    - Professores adicionam data de entrega
    - Alunos realizam a entrega das atividades

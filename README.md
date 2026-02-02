# Task Management System API

A robust RESTful API for project and task management, built with ASP.NET Core 6+ and Entity Framework Core. This system provides comprehensive features for managing projects, tasks, team collaboration, and workflow tracking.

## 🚀 Features

- **User Authentication & Authorization**
  - JWT-based authentication
  - Secure password hashing with BCrypt
  - Role-based access control

- **Board Management**
  - Create and manage project boards (similar to Trello/Asana)
  - Board ownership and member management
  - Role-based permissions (Owner, Admin, Member, Viewer)

- **Task Management**
  - Create, update, and delete tasks
  - Task status tracking (To Do, In Progress, Done)
  - Priority levels (Low, Medium, High)
  - Due date management
  - User assignments

- **Collaboration Features**
  - Comments on tasks
  - File attachments
  - Multi-user task assignments
  - Board member invitations

- **Authorization & Security**
  - Users can only access boards they own or are members of
  - Granular permissions for board operations
  - Secure API endpoints with JWT validation

## 🛠️ Technologies Used

- **Backend Framework:** ASP.NET Core Web API
- **ORM:** Entity Framework Core
- **Database:** SQL Server (LocalDB for development)
- **Authentication:** JWT (JSON Web Tokens)
- **Password Hashing:** BCrypt.Net
- **API Documentation:** Swagger/OpenAPI

## 📋 Prerequisites

- .NET 6.0 SDK or higher
- SQL Server or SQL Server LocalDB
- Visual Studio 2022 or VS Code (optional)

## ⚙️ Installation & Setup

1. **Clone the repository**
```bash
   git clone https://github.com/Sjaypeter/TaskManagementSystem.git
   cd TaskManagementSystem
```

2. **Update the connection string**
   
   Edit `appsettings.json` and configure your database connection:
```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=TaskManagementDB;Trusted_Connection=true"
   }
```

3. **Apply database migrations**
```bash
   dotnet ef database update
```

4. **Run the application**
```bash
   dotnet run
```

5. **Access the API**
   - API: `https://localhost:5001`
   - Swagger UI: `https://localhost:5001/swagger`

## 📚 API Endpoints

### Authentication
- `POST /api/auth/register` - Register a new user
- `POST /api/auth/login` - Login and receive JWT token

### Boards
- `GET /api/boards` - Get all accessible boards
- `GET /api/boards/{id}` - Get board details
- `POST /api/boards` - Create a new board
- `PUT /api/boards/{id}` - Update a board
- `DELETE /api/boards/{id}` - Delete a board
- `POST /api/boards/{id}/members` - Add a member to board
- `DELETE /api/boards/{boardId}/members/{memberId}` - Remove a member

### Tasks *(Coming Soon)*
- Task CRUD operations
- Status and priority updates
- User assignments
- Comments and attachments

## 🔐 Authentication

This API uses JWT Bearer token authentication. After logging in or registering, include the token in subsequent requests:
```
Authorization: Bearer <your-jwt-token>
```

## 📊 Database Schema

The system uses the following main entities:
- **Users** - System users with authentication
- **Boards** - Project boards with ownership
- **Tasks** - Individual tasks with status and priority
- **BoardMembers** - Many-to-many relationship with roles
- **TaskAssignments** - User assignments to tasks
- **Comments** - Task comments
- **FileAttachments** - Task file uploads

## 🎯 Roadmap

- [x] User authentication with JWT
- [x] Board CRUD operations
- [x] Board member management
- [ ] Task CRUD operations
- [ ] Task assignments and status tracking
- [ ] Comments system
- [ ] File upload functionality
- [ ] Email notifications
- [ ] Task filtering and search
- [ ] Frontend client (React/Angular)

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## 📝 License

This project is open source and available under the [MIT License](LICENSE).

## 👤 Author

**Sjaypeter**
- GitHub: [@Sjaypeter](https://github.com/Sjaypeter)

## 🙏 Acknowledgments

- Built as an intermediate portfolio project to demonstrate C# and Entity Framework skills
- Inspired by project management tools like Trello and Asana

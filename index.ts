 
import express from 'express';
import fs from 'fs';
import path from 'path';

const app = express();
const PORT = 3000;
const dbPath = path.join(__dirname, 'db.json');

app.use(express.json());

interface Submission {
    name: string;
    email: string;
    phone: string;
    github_link: string;
    stopwatch_time: string;
}

const readDatabase = (): { submissions: Submission[] } => {
    const data = fs.readFileSync(dbPath, 'utf8');
    return JSON.parse(data);
};

const writeDatabase = (data: { submissions: Submission[] }) => {
    fs.writeFileSync(dbPath, JSON.stringify(data, null, 2));
};

app.get('/ping', (req, res) => {
    res.json(true);
});

app.post('/submit', (req, res) => {
    const { name, email, phone, github_link, stopwatch_time } = req.body;

    if (!name || !email || !phone || !github_link || !stopwatch_time) {
        return res.status(400).send('Missing required fields');
    }

    const newSubmission: Submission = { name, email, phone, github_link, stopwatch_time };
    const db = readDatabase();
    db.submissions.push(newSubmission);
    writeDatabase(db);

    res.status(201).json(newSubmission);
});

app.get('/read', (req, res) => {
    const index = parseInt(req.query.index as string);

    if (isNaN(index) || index < 0) {
        return res.status(400).send('Invalid index');
    }

    const db = readDatabase();

    if (index >= db.submissions.length) {
        return res.status(404).send('Submission not found');
    }

    res.json(db.submissions[index]);
});

app.listen(PORT, () => {
    console.log(`Server running on port ${PORT}`);
});


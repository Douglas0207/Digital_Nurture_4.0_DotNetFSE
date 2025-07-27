import { Link } from "react-router-dom";

function TrainersList({ trainers }) {
  return (
    <div>
      <h2>Trainer List</h2>
      <ul>
        {trainers.map((trainer) => (
          <li key={trainer.id}>
            <Link to={`/trainers/${trainer.id}`}>{trainer.name}</Link>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default TrainersList;

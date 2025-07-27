import React ,{Component} from 'react';
import Post from './Post';

class Posts extends Component {
    constructor(props){
        super(props);
        this.state = {
            posts: [],
            hasError:false
        };
    }
    loadPosts = () => {
        fetch("https://jsonplaceholder.typicode.com/posts")
        .then((res) => res.json())
        .then((data) => {
            const postList = data.slice(0,10).map(
                (p) => new Post(p.userId,p.id,p.title,p.body)
            );
            this.setState({posts:postList});
        })
        .catch((error) => {
            console.error("Error fetching posts:",error);
            this.setState({hasError:true});
        });
    };
    componentDidMount() {
        this.loadPosts();
    }
    componentDidCatch(error,info) {
        console.log("Error caught in component:", error);
        alert("Something went wrong!");
        this.setState({hasError:true});
    }
    render()
    {
        if(this.state.hasError)
        {
            return <h2>Error loading posts.</h2>
        }
        return (
            <div style={{padding:"20px"}}>
                <h1>Blog Posts</h1>
                {this.state.posts.map((post) => (
                    <div key={post.id} style={{marginBottom:"20px"}}>
                        <h2>{post.title}</h2>
                        <p>{post.body}</p>
                        <hr />
                    </div>
                ))}
            </div>
        );
    }
}

export default Posts;
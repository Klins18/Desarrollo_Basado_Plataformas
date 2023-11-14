from flask import Flask

app = Flask(__name__)

@app.route("/")
def index():
    return render_template("todolist.html")
@app.route('/redireccionar')
def redireccionar():
    return redirect(url_for(' .html'))
if __name__== '__main__':
    app.run(debug=True)
